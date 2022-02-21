using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Distributor
    {
        [Key]
        public int DistribitorID{ get; set; }
        //
       public ICollection<Order> Orders { get; set; }
        //
        public string Dname { get;  set; }
        public string Dmail { get;  set; }
        public string Dadress { get;  set; }
        public string Dphone { get;  set; }
    }
}
