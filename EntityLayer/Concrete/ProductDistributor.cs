using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductDistributor
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Distributor> Distributors { get; set; }

    }
}
