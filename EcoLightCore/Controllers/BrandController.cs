using BusinessLAyer.Abstract;
using BusinessLAyer.Concrete;
using DataAccessLayer.EntityFrmaework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoLightCore.Controllers
{
    public class BrandController : Controller
    {
        IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            return View(_brandService.BListAll());
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Add(Brand p)
        {
            _brandService.BAdd(p);
            return RedirectToAction("Index");
        }
    }
}
