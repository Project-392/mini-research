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
        private static HttpClient client = new HttpClient();
        private const string baseUrl = "https://world.openpetfoodfacts.org/api/v2/product/";

        public class Offer
        {
            public string ReviewRating { get; set; }
            public string ReviewCount { get; set; }
            public string Price { get; set; }
            public string Link { get; set; }
            public string Title { get; set; }
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

            // Get product info from openpetfoodfacts API
            string productInfo = await GetProductInfo(input.Barcode);
            if (string.IsNullOrEmpty(productInfo))
                return NotFound("Product information not found.");

            try
            {
                var parsedProductInfo = JObject.Parse(productInfo);
                var name = parsedProductInfo["product"]["product_name"]?.ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    string apiKey = ""; // Replace with your actual API key
                    List<Offer> amazonResults = await AmazonSearchResult(name, apiKey);
                    return Ok(amazonResults);
                }

                return NotFound("Product name not found in product info.");
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        private static async Task<string> GetProductInfo(string barcode)
        {
            string url = baseUrl + barcode;
            using (var response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException($"Failed to retrieve product info. Status code: {response.StatusCode}");
                }
            }
        }

        private static async Task<List<Offer>> AmazonSearchResult(string searchTerm, string APIKEY)
        {
            List<Offer> offersList = new List<Offer>();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://real-time-amazon-data.p.rapidapi.com/search?query={searchTerm}&page=1&country=US&category_id=aps"),
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
                    .ThenByDescending(offer => offer.ReviewCount)
                    .Take(3)
                    .ToList();

                offersList.AddRange(products);
                return offersList;
            }
        }
    }
}
