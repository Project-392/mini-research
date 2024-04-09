using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZXing;
using ZXing.Common;
using System.IO;
using Newtonsoft.Json.Linq;

namespace barcode
{
    public partial class Form1 : Form
    {
        public class Offer
        {
            public string ReviewRating { get; set; }
            public string ReviewCount { get; set; }
            public string Price { get; set; }
            public string Link { get; set; }
            public string Name { get; set; }
        }

        private static HttpClient client = new HttpClient();

        private async void btnScan_Click(object sender, EventArgs e)
        {
            if (txtAPI.Text == "")
            {
                rtxtResults.Text = ("Please enter your API key in the text box.");
                return;
            }
            rtxtResults.Text = "Searching..."; // use RichTextBox for displaying results
            string barcode = txtBarcode.Text;
            string productInfo = await GetProductInfo(barcode);
            string name = "";

            // parse the JSON and display the relevant information
            try
            {
                var parsedProductInfo = Newtonsoft.Json.Linq.JObject.Parse(productInfo);
                name = parsedProductInfo["product"]["product_name"]?.ToString();
                string ingredients = parsedProductInfo["product"]["ingredients_text"]?.ToString();

                // parsing nutritional information
                string energy = parsedProductInfo["product"]["nutriments"]["energy_100g"]?.ToString();
                string proteins = parsedProductInfo["product"]["nutriments"]["proteins_100g"]?.ToString();
                string fat = parsedProductInfo["product"]["nutriments"]["fat_100g"]?.ToString();
                string carbohydrates = parsedProductInfo["product"]["nutriments"]["carbohydrates_100g"]?.ToString();

                // parsing ingredient analysis
                string additives = parsedProductInfo["product"]["additives_tags"]?.ToString();
                string vitamins = parsedProductInfo["product"]["vitamins_tags"]?.ToString();
                string minerals = parsedProductInfo["product"]["minerals_tags"]?.ToString();

                // displaying all the parsed information
                rtxtResults.Text = $"Name: {name}\n" +
                                   $"Ingredients: {ingredients}\n" +
                                   $"Energy: {energy} kcal\n" +
                                   $"Protein: {proteins} g\n" +
                                   $"Fat: {fat} g\n" +
                                   $"Carbohydrates: {carbohydrates} g\n" +
                                   $"Additives: {additives}\n" +
                                   $"Vitamins: {vitamins}\n" +
                                   $"Minerals: {minerals}\n";
            }
            // if parsing fails
            catch (Newtonsoft.Json.JsonReaderException)
            {
                rtxtResults.Text = "Failed to parse product info.";
            }
            catch (Exception ex)
            {
                rtxtResults.Text = $"An error occurred: {ex.Message}";
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                List<Offer> amazonResults = await AmazonSearchResult(name, txtAPI.Text);
                StringBuilder amazonResultsText = new StringBuilder();
                amazonResultsText.AppendLine("\nAmazon Results:");
                foreach (var offer in amazonResults)
                {
                    amazonResultsText.AppendLine($"Name: {offer.Name}, Price: {offer.Price}, Rating: {offer.ReviewRating}, Review Count: {offer.ReviewCount}, Link: {offer.Link}");
                }

                rtxtResults.AppendText(amazonResultsText.ToString());
            }

        }

        // event handler for the Upload button click
        private void btnUpload_Click(object sender, EventArgs e)
        {
            // open file dialog to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.jpeg;*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            // if a file is selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // create a PictureBox and load the selected image
                PictureBox pb = new PictureBox();
                pb.Image = new Bitmap(openFileDialog.FileName);

                // initialize a BarcodeReader to decode the barcode from the image
                BarcodeReader barcodeReader = new BarcodeReader();
                var result = barcodeReader.Decode((Bitmap)pb.Image);

                // if a barcode is detected in the image
                if (result != null)
                {
                    txtBarcode.Text = result.Text;
                    // perform the product info retrieval and display process here
                    btnScan_Click(sender, e);
                }
                else
                {
                    rtxtResults.Text = "No barcode detected. Try another image.";
                }
            }
        }

        // every barcode has its own json so append barcode to link
        private static readonly string baseUrl = "https://world.openpetfoodfacts.org/api/v2/product/";

        private static async Task<string> GetProductInfo(string barcode)
        {
            // construct the URL with the barcode
            string url = baseUrl + barcode;
            // send a GET request to the API
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "PetFoodScannerTest/1.0 (jsham1031@gmail.com)");
                try
                {
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        return "Product not found or an error occurred.";
                    }
                }
                catch (HttpRequestException ex)
                {
                    return "Error retrieving product information: " + ex.Message;
                }
            }
        }

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
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var jobId = getJobId(body);
                    if (!string.IsNullOrEmpty(jobId))
                    {
                        var jobResults = await PollJob(jobId, APIKEY);
                        var jsonResponse = JObject.Parse(jobResults);
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
                            await Task.Delay(10000); // Delay for 5 seconds
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

        private void btn_database_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
