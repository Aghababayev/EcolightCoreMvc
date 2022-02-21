using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoLightCore.Controllers
{
    public class DistributorController : Controller
    {

        IDistributorDAL _distributorDAL;

        public DistributorController(IDistributorDAL distributorDAL)
        {
            _distributorDAL = distributorDAL;
        }

        public IActionResult Index()
        {
            return View(_distributorDAL.GetListALL());
        }
    }
}
