using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EcoLightCore.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Index(User p)
        {
            using var c = new Context();
            var value = c.Users.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (value != null)
            {
                var claims = new List<Claim>
              {
                  new Claim(ClaimTypes.Name, p.UserName)
              };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);  
                await HttpContext.SignInAsync(principal);
                RedirectToAction("Index", "Product");  
            
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Home");
        
        }
    }
}






