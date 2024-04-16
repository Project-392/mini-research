using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace SQL_DATABASE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScanController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        private const string baseUrl = "https://world.openpetfoodfacts.org/api/v2/product/";

        public class Offer
        {
            public string ReviewRating { get; set; }
            public string ReviewCount { get; set; }
            public string Price { get; set; }
            public string Link { get; set; }
            public string Name { get; set; }
        }

        public class BarcodeRequest
        {
            public string Barcode { get; set; }
        }

        static ScanController()
        {
            client.DefaultRequestHeaders.Add("User-Agent", "PetFoodScannerTest/1.0 (jsham1031@gmail.com)");
        }

        [HttpPost]
        public async Task<IActionResult> PostScan([FromBody] BarcodeRequest barcodeRequest)
        {

            string barcode = barcodeRequest.Barcode;
            if (string.IsNullOrEmpty(barcode))
            {
                return BadRequest("Barcode is required.");
            }
         
            string productInfo = await GetProductInfo(barcode);
            if (string.IsNullOrEmpty(productInfo))
            {
                return NotFound("Product information not found.");
            }

            JObject parsedProductInfo = JObject.Parse(productInfo);
            string name = parsedProductInfo["product"]["product_name"]?.ToString();
            Console.WriteLine(name);
            if (!string.IsNullOrEmpty(name))
            {
                string apiKey = ""; // Replace with your actual API key
                List<Offer> amazonResults = await AmazonSearchResult(name, apiKey);
                return Ok(amazonResults);
            }

            return NotFound("Product name not found in product info.");
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
            List<Offer> offersList = new List<Offer>();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://price-analytics.p.rapidapi.com/search-by-term"),
                Headers =
            {
                { "X-RapidAPI-Key", APIKEY },
                { "X-RapidAPI-Host", "price-analytics.p.rapidapi.com" },
            },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "source", "amazon" },
                { "country", "us" },
                { "values", searchTerm },
            }),
            };

            try
            {
                using (var response = await client.SendAsync(request))
                {
                    // throws an exception if the HTTP response status code does not indicate success
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var jobId = getJobId(body);
                    if (!string.IsNullOrEmpty(jobId))
                    {
                        var jobResults = await PollJob(jobId, APIKEY);
                        var jsonResponse = JObject.Parse(jobResults);
                        // Console.WriteLine("API Response: " + jsonResponse.ToString());
                        var offers = jsonResponse["results"][0]["content"]["offers"]
                        .Select(offer => new Offer
                        {
                            ReviewRating = offer["shop_review_rating"]?.ToString(),
                            ReviewCount = offer["shop_review_count"]?.ToString(),
                            Price = offer["price"]?.ToString(),
                            Link = offer["link"]["href"]?.ToString(),
                            Name = offer["name"]?.ToString()
                        })
                        .OrderByDescending(offer => offer.ReviewRating)
                        .ThenByDescending(offer => offer.ReviewCount)
                        .Take(3)
                        .ToList();

                        offersList.AddRange(offers);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error submitting search: {ex.Message}");
            }

            return offersList;
        }

        // Continuously polls the status of a search job using a provided job ID and API key until the job is finished. 
        // It checks the job status every 15 seconds and returns the final job results once complete.
        private static async Task<string> PollJob(string jobId, string APIKEY)
        {
            bool isJobFinished = false;
            string jobResults = "";
            while (!isJobFinished)
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://price-analytics.p.rapidapi.com/poll-job/{jobId}"),
                    Headers =
                {
                    { "X-RapidAPI-Key", APIKEY },
                    { "X-RapidAPI-Host", "price-analytics.p.rapidapi.com" },
                },
                };

                try
                {
                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();
                        var status = getStatus(body);

                        if (status == "finished")
                        {
                            isJobFinished = true;
                            jobResults = body;
                        }
                        else
                        {
                            await Task.Delay(15000); // Delay for 15 seconds
                        }
                    }
                }
                catch (Exception)
                {
                    return "Error when polling job"; // Exit on error
                }
            }
            return jobResults;
        }
        // Extracts and returns the job ID from a response body, which is needed for polling the status of a job.
        private static string getJobId(string body)
        {
            var json = JObject.Parse(body);
            return json["job_id"]?.ToString();
        }

        private static string getStatus(string body)
        {
            var json = JObject.Parse(body);
            return json["status"]?.ToString();
        }
    }
}
