using BusinessLAyer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            _orderService.BAdd(p);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var val = _orderService.BGetById(id);
            _orderService.BDElete(val);
            return RedirectToAction("Index");
        }
        public IActionResult Update(Order p)
        {
            _orderService.BUpdate(p);
            return RedirectToAction("Index");
        }
        public IActionResult GetOrder(int id)
        {
            var ord = _orderService.BGetById(id);
            return View(ord);
        }
    }
}
