using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Brand
    {

        [Key]
        public int BrandID { get; set; }
        //
        public ICollection<Product> Products { get; set; }
        //
        public string BrandName { get; set; }
        public bool Available { get; set; } 
        
    }
}
