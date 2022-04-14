﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Models;
using System.Net.Http;
using static System.Web.HttpUtility;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test.Controllers
{
    public class CBResponse
    {
        public string text { get; set; }

    }
    public class HomeController : Controller
    {
        static HttpClient client = new HttpClient();
        private readonly ILogger<HomeController> _logger;

         public HomeController(ILogger<HomeController> logger)
        {
           
            

           
            _logger = logger;

        }

        public IActionResult Index()
        {
           
            return View(new DroneDataModel { id = 1 });
        }
        
        public IActionResult Chatbot()
        {
           
            //_ = getCBRespose("hey");
            return View();

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static async Task getCBRespose(string input)
        {
            var streamTask = client.GetStreamAsync("https://chatbot-api-dtqb5qffza-ue.a.run.app/test?text=" + UrlEncode(input));
            var response = await JsonSerializer.DeserializeAsync<CBResponse>(await streamTask);
            Console.Write(response);

        }
      
    }
}
