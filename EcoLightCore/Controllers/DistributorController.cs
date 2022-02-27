using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoLightCore.Controllers
{
    public class DistributorController : Controller
    {
 
        private readonly IDistributorDAL _distributorDAL;

        public DistributorController(IDistributorDAL distributorDAL)
        {
            _distributorDAL = distributorDAL;
        }

        public IActionResult Index()
        {
            return View(_distributorDAL.GetListALL());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Distributor p)
        {

            return View();
        }
    }
}
