using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Product
    {   [Key]
        public int ProductID { get; set; }
        //
        public ICollection<Order> Orders  { get; set; }
        //
        public string ProductName { get; set; }
        
        public int BrandID { get; set; }
        //
        public Brand Brand { get; set; }
        //
        public string Description{ get; set; }
        public int Lumens { get; set; } 
        public int Watt { get; set; }
        public int Stock { get; set; }
        public string Picture{ get; set; }
        public bool Available { get; set; }
    }
}
