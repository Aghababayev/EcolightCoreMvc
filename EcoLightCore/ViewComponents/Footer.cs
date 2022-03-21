using Microsoft.AspNetCore.Mvc;

namespace EcoLightCore.ViewComponents
{
    public class Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
          return View();    
        }
    }
}
