using System;
using System.Net.Http;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using AForge.Video;
using AForge.Video.DirectShow;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace barcode
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public Form1()
        {
            InitializeComponent();
            GetAvailableCameras();
            StartCameraCapture();
        }

        private void GetAvailableCameras()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCameras.Items.Add(device.Name);
            }

            // Only set the SelectedIndex if at least one camera is found
            if (comboBoxCameras.Items.Count > 0)
            {
                comboBoxCameras.SelectedIndex = 0;
            }
            else
            {
                // Handle the case when no cameras are found
                MessageBox.Show("No cameras found.");
            }
        }

        private void StartCameraCapture()
        {
            if (videoDevices.Count == 0) return;
            videoSource = new VideoCaptureDevice(videoDevices[comboBoxCameras.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtBarcode.Text = result.Text;
                    btnScan_Click(null, null); // Trigger barcode scanning
                });
            }
            bitmap.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            rtxtResults.Text = "Searching...";
            string barcode = txtBarcode.Text;
            string productInfo = await GetProductInfo(barcode);

            try
            {
                var parsedProductInfo = JObject.Parse(productInfo);
                DisplayProductInfo(parsedProductInfo);
            }
            catch (Exception ex)
            {
                rtxtResults.Text = $"An error occurred: {ex.Message}";
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PNG Image|*.png|JPG Image|*.jpg|JPEG Image|*.jpeg|Bitmap Image|*.bmp",
                Title = "Select a barcode image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Decode the barcode
                BarcodeReader reader = new BarcodeReader();
                var barcodeBitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
                var result = reader.Decode(barcodeBitmap);

                if (result != null)
                {
                    txtBarcode.Text = result.Text;
                    // Now perform the product search with the barcode
                    btnScan_Click(null, null);
                }
                else
                {
                    rtxtResults.Text = "Barcode could not be decoded from the image.";
                }
            }
        }
        private void DisplayProductInfo(JObject productInfo)
        {
            StringBuilder sb = new StringBuilder();

            string name = productInfo["product"]["product_name"]?.ToString();
            string ingredients = productInfo["product"]["ingredients_text"]?.ToString();
            string energy = productInfo["product"]["nutriments"]["energy_100g"]?.ToString();
            string proteins = productInfo["product"]["nutriments"]["proteins_100g"]?.ToString();
            string fat = productInfo["product"]["nutriments"]["fat_100g"]?.ToString();
            string carbohydrates = productInfo["product"]["nutriments"]["carbohydrates_100g"]?.ToString();
            string[] additives = productInfo["product"]["additives_tags"]?.ToObject<string[]>();
            string[] vitamins = productInfo["product"]["vitamins_tags"]?.ToObject<string[]>();
            string[] minerals = productInfo["product"]["minerals_tags"]?.ToObject<string[]>();

            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"Ingredients: {ingredients}");
            sb.AppendLine($"Energy: {energy} kcal");
            sb.AppendLine($"Protein: {proteins} g");
            sb.AppendLine($"Fat: {fat} g");
            sb.AppendLine($"Carbohydrates: {carbohydrates} g");

            if (additives != null && additives.Length > 0)
            {
                sb.AppendLine("Additives:");
                foreach (string additive in additives)
                {
                    // Remove the "en:" prefix
                    string cleanedAdditive = additive.Replace("en:", "");
                    sb.AppendLine($"- {cleanedAdditive}");
                }
            }

            if (vitamins != null && vitamins.Length > 0)
            {
                sb.AppendLine("Vitamins:");
                foreach (string vitamin in vitamins)
                {
                    string cleanedVitamin = vitamin.Replace("en:", "");
                    sb.AppendLine($"- {cleanedVitamin}");
                }
            }

            if (minerals != null && minerals.Length > 0)
            {
                sb.AppendLine("Minerals:");
                foreach (string mineral in minerals)
                {
                    string cleanedMineral = mineral.Replace("en:", "");
                    sb.AppendLine($"- {cleanedMineral}");
                }
            }

            rtxtResults.Text = sb.ToString();
        }


        private static readonly string baseUrl = "https://world.openpetfoodfacts.org/api/v2/product/";

        private static async Task<string> GetProductInfo(string barcode)
        {
            string url = baseUrl + barcode;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "PetFoodScannerTest/1.0");
                try
                {
                    var response = await client.GetAsync(url);
                    return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : "Product not found or an error occurred.";
                }
                catch (HttpRequestException ex)
                {
                    return "Error retrieving product information: " + ex.Message;
                }
            }
        }
    }
}
