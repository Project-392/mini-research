using Microsoft.AspNetCore.Mvc;
using OpenAI_API;
using OpenAI_API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQL_DATABASE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private static readonly List<string> Responses = new List<string>
        {
           "The average cat can jump up to six times its body length in one leap.",
"Cats can rotate their ears 180 degrees.",
"A group of cats is called a clowder.",
"Cats have a specialized collarbone that allows them to always land on their feet when they fall.",
"Cats can make over 100 different sounds."
        };

        private static readonly Random Random = new Random();

        public class InputModel
        {
            public string Text { get; set; }
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post(InputModel input)
        {
            // public OpenAI_API.Chat.Conversation chat;

            try
            {
                const string APIKEY = "";
                var api = new OpenAI_API.OpenAIAPI(APIKEY);
                var chat = api.Chat.CreateConversation();
                chat.Model = Model.ChatGPTTurbo;
                chat.AppendUserInput($"{input.Text}");
                string response = await chat.GetResponseFromChatbotAsync();
                return response;
            }
            catch(Exception ex) 
            {
                return ($"Error initializing conversation: {ex.Message}");
            }
        }
    }
}


