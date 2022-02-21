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
       

        public List<Product> Getbrandname()
        {
            using var c = new Context();
            return c.Products.Include(x => x.Brand).ToList();
        }

       
    }
}
