using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IOrderDAL : IGenericDAL<Order>
    {
        List<Order> GetProductDistributer();
        List<SelectListItem> DropdownDistributor();
        List<SelectListItem> DropdownProduct();


    }
}
