using BusinessLAyer.Abstract;
using BusinessLAyer.Validators;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace EcoLightCore.Controllers
{
    public class OrderController : Controller
    {
        readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        OrderValidator ov = new();

        public IActionResult Index()
        {
            return View(_orderService.BGetProductDistributer());
        }
        [HttpGet]
        public IActionResult Add()
        {
            //...........Order Add cshtml page dropdown fill
            ViewBag.dist = _orderService.BDropdownDistributor();
            ViewBag.prd = _orderService.BDropdownProduct();
            //.............................................................
            return View();
        }
        [HttpPost]
        public IActionResult Add(Order p)
        {
            ValidationResult result = ov.Validate(p);
            ViewBag.dist = _orderService.BDropdownDistributor();
            ViewBag.prd = _orderService.BDropdownProduct();
            if (result.IsValid)
            {
                p.OrderTime = DateTime.Now;
                _orderService.BAdd(p);
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
        public IActionResult Delete(int id)
        {
            var val = _orderService.BGetById(id);
            _orderService.BDElete(val);
            return RedirectToAction("Index");
        }
        public IActionResult Update(Order p)
        {
            ViewBag.dist = _orderService.BDropdownDistributor();
            ViewBag.prd = _orderService.BDropdownProduct();
            _orderService.BUpdate(p);
            return RedirectToAction("Index");
        }
        public IActionResult GetOrder(int id)
        {
            ViewBag.dist = _orderService.BDropdownDistributor();
            ViewBag.prd = _orderService.BDropdownProduct();
            var ord = _orderService.BGetById(id);
            return View(ord);
        }
    }
}
