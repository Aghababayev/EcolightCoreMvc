using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrmaework
{
    public class EFOrder : GenericRepository<Order>, IOrderDAL
    {
        public object DropdownDistributor()
        {
            using var c = new Context();
           return c.Distributors.Select(x => new SelectListItem { Value = x.DistribitorID.ToString(), Text = x.Dname }).ToList();
       
        }

        public object DropdownProduct()
        {
            using var c = new Context();
          return c.Products.Select(x => new SelectListItem { Value = x.ProductID.ToString(), Text = x.ProductName + " " + x.Brand.BrandName + " WATT:" + x.Watt }).ToList();
        }

        public List<Order> GetProductDistributer()
        {
          using var c=new Context();
            return  c.Orders.Include(x=>x.Product).ThenInclude(b=>b.Brand).Include(v=>v.Distributor).ToList();    
        }
    }
}
