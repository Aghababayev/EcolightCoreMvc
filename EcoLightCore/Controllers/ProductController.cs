
using BusinessLAyer.Validators;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrmaework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoLightCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductDAL _productDAL;

        public ProductController(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }//--------------------------------------------------------------------------------------------------------------------------

      
        public IActionResult Index()
        {

            return View(_productDAL.Getbrandname());
        }//--------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult Add()
        {
            using var c = new Context();
            List<SelectListItem> val = (from i in c.Brands.ToList()
                                        select new SelectListItem
                                        {
                                            Text = i.BrandName,
                                            Value = i.BrandID.ToString()
                                        }).ToList();


            @ViewBag.blst = val; 
            return View();
        }//--------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult Add(Product p)
        {
            using var c = new Context();
            List<SelectListItem> val = (from i in c.Brands.ToList()
                                        select new SelectListItem
                                        {
                                            Text = i.BrandName,
                                            Value = i.BrandID.ToString()
                                        }).ToList();
            @ViewBag.blst = val; 
            //_______________________________________________________________________________________________________________________
            ProductValidator pv = new ProductValidator();
            ValidationResult result = pv.Validate(p);
            if (result.IsValid)
            {
                _productDAL.Insert(p);
                return RedirectToAction("Index");
            }
            else {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }//--------------------------------------------------------------------------------------------------------------------------
        public IActionResult Delete(int id)
        {
            var val = _productDAL.GetById(id);
            _productDAL.Delete(val);
            return RedirectToAction("Index");
        }//--------------------------------------------------------------------------------------------------------------------------
        public IActionResult GetProduct(int id)
        {
            using var c = new Context();
            List<SelectListItem> val = (from i in c.Brands.ToList()
                                        select new SelectListItem
                                        {
                                            Text = i.BrandName,
                                            Value = i.BrandID.ToString()
                                        }).ToList();
            @ViewBag.blst = val;
            var prd = _productDAL.GetById(id);
            return View(prd);
        }//--------------------------------------------------------------------------------------------------------------------------
        public IActionResult Update(Product p)
        {
            using var c = new Context();
            List<SelectListItem> val = (from i in c.Brands.ToList()
                                        select new SelectListItem
                                        {
                                            Text = i.BrandName,
                                            Value = i.BrandID.ToString()
                                        }).ToList();
            @ViewBag.blst = val;
            //____________________________________________________________________________________________________
            ProductValidator pv = new ProductValidator();
            ValidationResult result = pv.Validate(p);
            if (result.IsValid)
            {
                _productDAL.Update(p);
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
          
        }//--------------------------------------------------------------------------------------------------------------------------

    }
}
