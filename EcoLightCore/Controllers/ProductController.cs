
using BusinessLAyer.Abstract;
using BusinessLAyer.Validators;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrmaework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoLightCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // --------------------------------------------------------------------------------------------------------------------------
        public IActionResult Index()
        {
            return View(_productService.BGetbrandname());
        }
        //--------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult Add()
        {
            using var c = new Context();
            @ViewBag.blst = c.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductName }).ToList();

            return View();
        }
        //--------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult Add(Product p)
        {
            using var c = new Context();
            @ViewBag.blst = c.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductName }).ToList(); ;
            //_______________________________________________________________________________________________________________________
            ProductValidator pv = new();
            ValidationResult result = pv.Validate(p);
            if (result.IsValid)
            {
                _productService.BAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        //--------------------------------------------------------------------------------------------------------------------------
        public IActionResult Delete(int id)
        {
            var val = _productService.BGetById(id);
            _productService.BDElete(val);
            return RedirectToAction("Index");
        }
        //--------------------------------------------------------------------------------------------------------------------------
        public IActionResult GetProduct(int id)
        {
            using var c = new Context();
            @ViewBag.blst = c.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductName }).ToList();
            var prd = _productService.BGetById(id);
            return View(prd);
        }
        //--------------------------------------------------------------------------------------------------------------------------
        public IActionResult Update(Product p)
        {
            using var c = new Context();

            @ViewBag.blst = c.Products.Select(p => new SelectListItem { Value = p.ProductID.ToString(), Text = p.ProductName }).ToList();

            //____________________________________________________________________________________________________
            ProductValidator pv = new();
            ValidationResult result = pv.Validate(p);
            if (result.IsValid)
            {
                _productService.BUpdate(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View("GetProduct");
        }
        //--------------------------------------------------------------------------------------------------------------------------

    }
}
