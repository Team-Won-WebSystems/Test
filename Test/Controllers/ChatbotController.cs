using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using static System.Web.HttpUtility;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test

{
    public class CBResponse
    {
        public string text { get; set; }
       
    }

    public class ChatbotController : Controller
    {

        static HttpClient client = new HttpClient();
        // GET: /<controller>/
        public void Index()
        {

            _ = getCBRespose("hey");
            
            
           
        }

        private static async Task getCBRespose(string input)
        {
            var streamTask = client.GetStreamAsync("https://chatbot-api-dtqb5qffza-ue.a.run.app/test?text=" + UrlEncode(input));
            var response = await JsonSerializer.DeserializeAsync<List<CBResponse>>(await streamTask);
            Console.Write(response);

        }
    }
}
