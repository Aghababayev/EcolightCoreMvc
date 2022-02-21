using EcoLightCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EcoLightCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {//https://api.openweathermap.org/data/2.5/weather?q=baku&mode=xml&units=metric&appid=9a977a12609ad684ffabc1967f653154
            string api = "9a977a12609ad684ffabc1967f653154";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=baku&mode=xml&units=metric&appid=" + api;
             XDocument document = XDocument.Load(connection);
            ViewBag.Weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;



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
    }
}
