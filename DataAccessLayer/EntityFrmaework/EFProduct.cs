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
    public class EFProduct : GenericRepository<Product>, IProductDAL
    {
        public object DropdownProduct()
        {
            using var c = new Context();
           return c.Brands.Select(p => new SelectListItem { Value = p.BrandID.ToString(), Text = p.BrandName }).ToList();
        }

        public List<Product> Getbrandname()
        {
            using var c = new Context();
            return c.Products.Include(x => x.Brand).ToList();
        }
       
       
    }
}
