using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Net.Http.Headers;

namespace ProductSearch_demo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter search term:");
            string searchTerm = Console.ReadLine();
            string encodedSearchTerm = searchTerm.Replace(" ", "%20");
            Console.WriteLine("Searching for: " + encodedSearchTerm);


            await FetchProductData(encodedSearchTerm);
        }

        // Submit search request. Copied from rapid api documentation
        private static async Task FetchProductData(string searchTerm)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://real-time-amazon-data.p.rapidapi.com/search?query={searchTerm}&page=1&country=US&category_id=aps"),
                Headers =
                {
                    { "X-RapidAPI-Key", "ef1277f066mshbfc54cfe307dc97p10382ajsncb25e3402900" },
                    { "X-RapidAPI-Host", "real-time-amazon-data.p.rapidapi.com" },
                },
            };

            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Results:");
                    DisplayResults(body);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
            }
        }


        private static void DisplayResults(string jsonData)
        {
            // Parse the JSON data
            var jsonResponse = JObject.Parse(jsonData);
            var products = jsonResponse["data"]["products"];

            // Use LINQ to order the products by star rating (descending) and number of ratings (descending)
            var sortedProducts = products
                .Select(p => new
                {
                    Title = (string)p["product_title"],
                    Price = (string)p["product_price"],
                    ReviewRating = (double)p["product_star_rating"],
                    ReviewCount = (int)p["product_num_ratings"],
                    Link = (string)p["product_url"]
                })
                .OrderByDescending(p => p.ReviewRating)
                .ThenByDescending(p => p.ReviewCount)
                .Take(3); // Take only the top three products

            // Display the sorted and selected products
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Title: {product.Title}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"Review Rating: {product.ReviewRating}");
                Console.WriteLine($"Review Count: {product.ReviewCount}");
                Console.WriteLine($"Link: {product.Link}\n");
            }
        }
    }
}
