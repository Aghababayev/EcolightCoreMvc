using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Abstract
{
    public interface IOrderService:IGenericService<Order>
    {
        List<Order> BGetProductDistributer();
        Object BDropdownDistributor();
        Object BDropdownProduct();
  
    }

}
