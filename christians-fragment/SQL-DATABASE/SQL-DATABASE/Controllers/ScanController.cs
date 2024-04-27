using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SQL_DATABASE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScanController : ControllerBase
    {
        // api key
        private const string APIKEY = "";
        private static HttpClient client = new HttpClient();

        // Used when ASIN is not available
        public class Offer
        {
            public string ReviewRating { get; set; }
            public string ReviewCount { get; set; }
            public string Price { get; set; }
            public string Link { get; set; }
            public string Title { get; set; }
        }

        // Used when ASIN is available
        public class SellerOffer
        {
            public string ProductPrice { get; set; }
            public string ProductCondition { get; set; }
            public string ShipsFrom { get; set; }
            public string Seller { get; set; }
            public string SellerLink { get; set; }
            public string SellerStarRating { get; set; }
            public string SellerStarRatingInfo { get; set; }
            public string Currency { get; set; }
            public string DeliveryPrice { get; set; }
            public string DeliveryTime { get; set; }
        }

        // Used to store product details
        public class ProductDetails
        {
            public string Name { get; set; }
            public string Ingredients { get; set; }
            public string Asin { get; set; }
            //  when ASIN is not available this is used
            public List<Offer> AmazonOffers { get; set; }
            // when ASIN is available this is used 
            public List<SellerOffer> AmazonSellerOffers { get; set; }
        }

        public class BarcodeInput
        {
            public string Barcode { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> UploadBarcode([FromBody] BarcodeInput input)
        {
            if (string.IsNullOrEmpty(input.Barcode))
                return BadRequest("No barcode provided.");

            // Get product info from openpetfoodfacts, upcitemdb, and big-product-data API
            ProductDetails productInfo = await FetchProductDetails(input.Barcode);

            /*Console.WriteLine("Product Name: " + productInfo.Name);
            Console.WriteLine("Product Ingredients: " + productInfo.Ingredients);
            Console.WriteLine("Product ASIN (AMAZON): " + productInfo.Asin);*/

            if (string.IsNullOrEmpty(productInfo.Name))
                return NotFound("Product information not found.");

            try
            {
                //if productinfo.asin is not null, search for the product on amazon using the asin
                if (!string.IsNullOrEmpty(productInfo.Asin))
                {
                    List<SellerOffer> amazonResults = await AmazonSearchResultASIN(productInfo.Asin);
                    productInfo.AmazonSellerOffers = amazonResults;
                    Console.WriteLine("Amazon Results from ASIN: " + amazonResults);
                }   
                else if (!string.IsNullOrEmpty(productInfo.Name))
                {
                    List<Offer> amazonResults = await AmazonSearchResult(productInfo.Name);
                    productInfo.AmazonOffers = amazonResults;
                } 
                else
                {
                    return NotFound("Product name not found in product info.");
                }

                return Ok(productInfo);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        // Fetch product details from openpetfoodfacts, upcitemdb, and big-product-data APIs
        public static async Task<ProductDetails> FetchProductDetails(string barcode)
        {
            ProductDetails details = new ProductDetails();

            // Fetch product name and basic info
            string openPetFoodFactUrl = "https://world.openpetfoodfacts.org/api/v2/product/" + barcode; // baseUrl should be adjusted as necessary
            var productInfoResponse = await client.GetAsync(openPetFoodFactUrl);
            if (productInfoResponse.IsSuccessStatusCode)
            {
                string productInfo = await productInfoResponse.Content.ReadAsStringAsync();
                var productJson = JObject.Parse(productInfo);
                Console.WriteLine("openpetfoodfacts:" + productJson);
                details.Name = productJson["product"]["product_name"]?.ToString() ?? null;
                /*if (details.Name == null)
                    Console.WriteLine("Product name not found in openpetfoodfacts API.");*/
            }
            else
            {
                return null;  // Or throw an exception or handle the error as required
            }

            // Fetch ASIN from another API
            string upcItemDBUrl = $"https://api.upcitemdb.com/prod/trial/lookup?upc={barcode}";
            client.DefaultRequestHeaders.Clear();  // Clear previous headers
            var upcItemDBResponse = await client.GetAsync(upcItemDBUrl);
            if (upcItemDBResponse.IsSuccessStatusCode)
            {
                string asinInfo = await upcItemDBResponse.Content.ReadAsStringAsync();
                var upcItemDBJson = JObject.Parse(asinInfo);
                details.Asin = upcItemDBJson["items"]?[0]?["asin"]?.ToString() ?? null;
                if (string.IsNullOrEmpty(details.Name))
                {
                    details.Name = upcItemDBJson["items"]?[0]?["title"]?.ToString();
                }
            }
            // Fetch ingredients from another API
            string bigProductDataUrl = $"https://big-product-data.p.rapidapi.com/gtin/{barcode}";
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", APIKEY);
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "big-product-data.p.rapidapi.com");
            var bigProductDataResponse = await client.GetAsync(bigProductDataUrl);
            if (bigProductDataResponse.IsSuccessStatusCode)
            {
                string bigProductDataInfo = await bigProductDataResponse.Content.ReadAsStringAsync();
                var bigProductDataJson = JObject.Parse(bigProductDataInfo);
                details.Ingredients = bigProductDataJson["properties"]?["ingredients"]?.ToString() ?? null;
                if (string.IsNullOrEmpty(details.Name))
                {
                    details.Name = bigProductDataJson["properties"]?["name"]?.ToString();
                }
            }
            return details;
        }

        public static async Task<List<SellerOffer>> AmazonSearchResultASIN(string asin)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://real-time-amazon-data.p.rapidapi.com/product-offers?asin={asin}&country=US&limit=10&page=1"),
                Headers =
        {
            { "X-RapidAPI-Key", APIKEY },
            { "X-RapidAPI-Host", "real-time-amazon-data.p.rapidapi.com" },
        },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var jsonResponse = JObject.Parse(body);

                var offers = jsonResponse["data"]["product_offers"]
                .Select(o => new SellerOffer
                {
                    ProductPrice = (string)o["product_price"],
                    ProductCondition = (string)o["product_condition"],
                    ShipsFrom = (string)o["ships_from"],
                    Seller = (string)o["seller"],
                    SellerLink = (string)o["seller_link"],
                    SellerStarRating = (string)o["seller_star_rating"],
                    SellerStarRatingInfo = (string)o["seller_star_rating_info"],
                    Currency = (string)o["currency"],
                    DeliveryPrice = (string)o["delivery_price"],
                    DeliveryTime = (string)o["delivery_time"]
                })
                .ToList();
                return offers;
            }
        }

        private static async Task<List<Offer>> AmazonSearchResult(string searchTerm)
        {
            List<Offer> offersList = new List<Offer>();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://real-time-amazon-data.p.rapidapi.com/search?query={searchTerm}&page=1&country=US&sort_by=RELEVANCE&category_id=aps"),
                Headers =
                {
                    { "X-RapidAPI-Key", APIKEY },
                    { "X-RapidAPI-Host", "real-time-amazon-data.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var jsonResponse = JObject.Parse(body);
                var products = jsonResponse["data"]["products"]
                    .Select(p => new Offer
                    {
                        Title = (string)p["product_title"],
                        Price = (string)p["product_price"],
                        ReviewRating = (string)p["product_star_rating"],
                        ReviewCount = (string)p["product_num_ratings"],
                        Link = (string)p["product_url"]
                    })
                    .OrderByDescending(offer => offer.ReviewRating)
                    .Take(3)
                    .ToList();

                offersList.AddRange(products);
                return offersList;
            }
        }
    }
}
