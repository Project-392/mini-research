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

namespace barcode
{
    public partial class Form1 : Form
    {

        private async void btnScan_Click(object sender, EventArgs e)
        {
            rtxtResults.Text = "Searching..."; // use RichTextBox for displaying results
            string barcode = txtBarcode.Text;
            string productInfo = await GetProductInfo(barcode);

            // parse the JSON and display the relevant information
            try
            {
                var parsedProductInfo = Newtonsoft.Json.Linq.JObject.Parse(productInfo);
                string name = parsedProductInfo["product"]["product_name"]?.ToString();
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
                                   $"Minerals: {minerals}";
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
    }
}
