using System;
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

            List<FAQModel> faq = new List<FAQModel>();

            faq.Add(new FAQModel { id = 1, title = "Why do I need an account?", description = "We provide an account option so you can save your work and overall have a better expereince!", icon = "😀" , open = false});
            faq.Add(new FAQModel { id = 2, title = "How do I create a website?", description = "Construction.Site makes it super easy, just press this link below and follow the steps...", icon = "🚧", open = false });
            faq.Add(new FAQModel { id = 3, title = "Where is my data stored?", description = "Data is stored on a secure server", icon = "🔐", open = false });
            faq.Add(new FAQModel { id = 4, title = "What personal data is stored?", description = "We collect login information, cookies, and your website info", icon = "💿", open = false });
            faq.Add(new FAQModel { id = 5, title = "Why is my data stored?", description = "We collect data so we can give you the best experience possible", icon = "❓", open = false });
            faq.Add(new FAQModel { id = 6, title = "Why should I build a website?", description = "Websites are great for building a business", icon = "👨‍💼", open = false });
            faq.Add(new FAQModel { id = 7, title = "How does the webiste builder work?", description = "We use machine learning and an intuitive layout to help you grow your business", icon = "🪴", open = false });
            faq.Add(new FAQModel { id = 8, title = "How are your payments secure?", description = "We use Stripe to secure yoru transactions", icon = "💰", open = false });
            faq.Add(new FAQModel { id = 9, title = "Do we run discounts and deals?", description = "Yes! We routinely have deals!", icon = "🤝", open = false });
            faq.Add(new FAQModel { id = 10, title = "Who can I contact for more support?", description = "Feel free to contact is at support@construction.site so we can further assist you!", icon = "🚀", open = false });

            return View(faq);

        }


        public IActionResult Auth()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Press()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
