using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace ProductSearch_demo
{
    internal class Program
    {
        private static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter search term:");
            string searchTerm = Console.ReadLine();
            await SubmitSearch(searchTerm);
        }

        private static async Task SubmitSearch(string searchTerm)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://price-analytics.p.rapidapi.com/search-by-term"),
                Headers =
            {
                { "X-RapidAPI-Key", "44964a2e2amsh07a4eab6b5f61bdp12b2bcjsn61d50e3049d1" },
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
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var jobId = getJobId(body);
                    if (!string.IsNullOrEmpty(jobId))
                    {
                        Console.WriteLine($"Job submitted successfully. Job ID: {jobId}");
                        await PollJob(jobId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error submitting search: {ex.Message}");
            }
        }

        private static async Task PollJob(string jobId)
        {
            bool isJobFinished = false;
            Console.WriteLine("Polling job status...");
            while (!isJobFinished)
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://price-analytics.p.rapidapi.com/poll-job/{jobId}"),
                    Headers =
                {
                    { "X-RapidAPI-Key", "44964a2e2amsh07a4eab6b5f61bdp12b2bcjsn61d50e3049d1" },
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
                            Console.WriteLine("Job finished. Results:");
                            DisplayTopOffers(body);
                        }
                        else
                        {
                            Console.WriteLine("Job still processing. Waiting before polling again...");
                            await Task.Delay(5000); // Delay for 5 seconds
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error polling job status: {ex.Message}");
                    return; // Exit on error
                }
            }
        }

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

        private static void DisplayTopOffers(string jobResults)
        {
            var jsonResponse = JObject.Parse(jobResults);
            var offers = jsonResponse["results"][0]["content"]["offers"]
                .Select(offer => new
                {
                    ReviewRating = offer["shop_review_rating"],
                    ReviewCount = offer["shop_review_count"],
                    Price = offer["price"],
                    Link = offer["link"]["href"], 
                    Name = offer["name"]
                })
                .OrderByDescending(offer => offer.ReviewRating)
                .ThenByDescending(offer => offer.ReviewCount)
                .Take(10);

            foreach (var offer in offers)
            {
                Console.WriteLine($"Name: {offer.Name}, Price: {offer.Price}, Rating: {offer.ReviewRating}, Review Count: {offer.ReviewCount}, Link: {offer.Link}");
            }
        }
    }
}
