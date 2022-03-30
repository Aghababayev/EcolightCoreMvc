using BusinessLAyer.Abstract;
using EcoLightCore.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EcoLightCore.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOrderService _orderService;   
        public HomeController(ILogger<HomeController> logger, IOrderService orderService)
        {
            _logger = logger;
         _orderService = orderService;  
        }

        public IActionResult Index()
        {
            ViewBag.dist = _orderService.BDropdownDistributor();
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Distributor()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
