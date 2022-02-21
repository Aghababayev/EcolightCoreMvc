using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        
       public int DistributorID { get; set; }
        //
        public Distributor Distributor { get; set; }
        //
        public int ProductID { get; set; }
        //
        public Product Product { get; set; }
        //
        public int Quantity { get; set; }
    }

}
