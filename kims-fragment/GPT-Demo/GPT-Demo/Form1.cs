using OpenAI_API;
using OpenAI_API.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using dotenv.net;
using System.IO;

namespace GPT_Demo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string userInput = "";
        public string response = "";
        private async void userSubmitBtn_Click(object sender, EventArgs e)
        {
            string userInput = userInputTxt.Text;
            string response = await GetGptResponseAsync(userInput);
            gptOutputTxt.Text = response;
            userInputTxt.Clear();
        }
        // https://github.com/OkGoDoIt/OpenAI-API-dotnet?tab=readme-ov-file#chat-api 
        private async Task<string> GetGptResponseAsync(string input)
        {
            try
            {
                // Load API key (preferably from a secure place like environment variables)
                DotEnv.Load();
                string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
                MessageBox.Show(Directory.GetCurrentDirectory());
                OpenAIAPI api = new OpenAIAPI(apiKey);
                // Setup conversation (assuming this is the correct way per your library)
                var chat = api.Chat.CreateConversation();
                chat.Model = Model.ChatGPTTurbo; // Set the model, make sure it is available in your API plan

                // Append user input and get response
                chat.AppendUserInput(input);
                return await chat.GetResponseFromChatbotAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error in processing your request.";
            }
        }
    }
}
