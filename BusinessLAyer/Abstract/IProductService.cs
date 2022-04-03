using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLAyer.Abstract
{
  public interface IProductService : IGenericService<Product>
    {
        List<Product> BGetbrandname();
      List<SelectListItem> BDropdownproduct();
     
    }
    
}
