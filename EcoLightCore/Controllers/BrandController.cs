using BusinessLAyer.Abstract;
using BusinessLAyer.Concrete;
using BusinessLAyer.Validators;
using DataAccessLayer.EntityFrmaework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoLightCore.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        //_______________________________________________________________________________________________
        public IActionResult Index()
        {
            return View(_brandService.BListAll());
        }

        //_______________________________________________________________________________________________
        [HttpGet]
        public IActionResult Add()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Add(Brand p)
        {
            BrandValidator bv = new();
            ValidationResult result = bv.Validate(p);
            if (result.IsValid)
            {
                _brandService.BAdd(p);
                return RedirectToAction("Index");
            }
            else {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        //_______________________________________________________________________________________________
        public IActionResult Get(int id)
        {
            var val = _brandService.BGetById(id);
            return View(val);
        }
        //_______________________________________________________________________________________________
        public IActionResult Update(Brand p)
        {
            BrandValidator bv = new();
            ValidationResult result = bv.Validate(p);
            if (result.IsValid)
            {
                _brandService.BUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View("Get");

        }
        //_______________________________________________________________________________________________
        public IActionResult Delete(int id)
        {
            var val = _brandService.BGetById(id);
            _brandService.BDElete(val);
            return RedirectToAction("Index");
         }
    }
}
