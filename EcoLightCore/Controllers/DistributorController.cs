using BusinessLAyer.Abstract;
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

        private readonly IDistributorService _distributorService;

        public DistributorController(IDistributorService distributorService)
        {
            _distributorService = distributorService;
        }

        public IActionResult Index()
        {
            return View(_distributorService.BListAll());
        }
        //______________________________________________________________________________________________________________
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        //______________________________________________________________________________________________________________
        [HttpPost]
        public IActionResult Add(Distributor p)
        {
            _distributorService.BAdd(p);
            return RedirectToAction("Index");
        }
        //______________________________________________________________________________________________________________
        public IActionResult Delete(int id)
        { var val = _distributorService.BGetById(id);
            _distributorService.BDElete(val);
            return RedirectToAction("Index");

        }
        //______________________________________________________________________________________________________________
        public IActionResult Get(int id)
        {
         var dist  = _distributorService.BGetById(id);
            return View(dist);
        
        }
        //______________________________________________________________________________________________________________
        public IActionResult Update(Distributor p)
        {
            _distributorService.BUpdate(p);
            return View("Index");

        
        }
    }
}
