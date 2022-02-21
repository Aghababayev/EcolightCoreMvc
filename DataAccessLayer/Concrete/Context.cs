
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               optionsBuilder.UseSqlServer("server=NB062\\MSSQLSERVER01;database=EcoLightCoreDB;integrated security=true;");

          
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Order> Orders{ get; set; }

    }



}

    
    
    

