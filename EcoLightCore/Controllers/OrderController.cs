using BusinessLAyer.Abstract;
using Microsoft.AspNetCore.Mvc;

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
    }
}
