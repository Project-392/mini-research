using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ZXing;
using ZXing.Common;
using System.Drawing;
using System.IO;
using ZXing.Windows.Compatibility;

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


        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadBarcode([FromForm] IFormFile file)
        {


            // Console.WriteLine("File uploaded");

            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");


            // Decode barcode
            string barcode = null;
            try
            {
                using (var stream = file.OpenReadStream())
                using (var bitmap = new Bitmap(stream)) // Create Bitmap directly from the stream
                {
                    var barcodeReader = new BarcodeReader()
                    {
                        AutoRotate = true,
                        Options = new DecodingOptions { TryHarder = true }
                    };
                    var result = barcodeReader.Decode(bitmap);
                    if (result != null)
                    {
                        barcode = result.Text;
                        Console.WriteLine($"Decoded barcode: {barcode}");
                    }
                    else
                    {
                        return BadRequest("Barcode could not be decoded from the image.");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Error decoding barcode: {ex.Message}");
            }


            if (string.IsNullOrEmpty(barcode))
                return BadRequest("Barcode could not be decoded from the image.");

            // Get product info from openpetfoodfacts API
            string productInfo = await GetProductInfo(barcode);
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

        // Retrieves product information from an external API using a given barcode. It constructs a URL using the barcode, makes an HTTP GET request, and returns the response as a string if successful. 
        //It throws an exception if the request fails.
        private static async Task<string> GetProductInfo(string barcode)
        {
            string url = baseUrl + barcode;
            // initiates an asynchronous GET request to the URL specified by the 'url' variable.
            // 'using' ensures that 'HttpResponseMessage' is disposed of correctly once its not needed
            // Why we use async here: 
            //     Asynchronous methods do not block the thread on which they are executed while waiting for the operation (like a network call) to complete. 
            //     Instead, the thread is freed up to perform other work. 
            using (var response = await client.GetAsync(url))
            {
                client.DefaultRequestHeaders.Add("User-Agent", "PetFoodScannerTest/1.0 (jsham1031@gmail.com)");
                // 'IsSuccessStatudCode' checks the status code of the HTTP response to see if its successful.
                if (response.IsSuccessStatusCode)
                {
                    // If the HTTP response was successful, this line reads the content of the response as a string asynchronously
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException($"Failed to retrieve product info. Status code: {response.StatusCode}");
                }
            }
        }

        // Continuously polls the status of a search job using a provided job ID and API key until the job is finished. 
        // It checks the job status every 15 seconds and returns the final job results once complete.
        private static async Task<List<Offer>> AmazonSearchResult(string searchTerm, string APIKEY)
        {
            // Console.WriteLine("Searching Amazon for: " + searchTerm);
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

            try
            {
                using (var response = await client.SendAsync(request))
                {
                    // throws an exception if the HTTP response status code does not indicate success
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

                    //
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error submitting search: {ex.Message}");
            }

            return offersList;
        }
    }
}
