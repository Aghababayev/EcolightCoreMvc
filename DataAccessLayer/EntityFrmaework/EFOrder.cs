using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
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
        public List<Order> GetProductDistributer()
        {
          using var c=new Context();
            return  c.Orders.Include(x=>x.Product).ThenInclude(b=>b.Brand).Include(v=>v.Distributor).ToList();    
        }
    }
}
