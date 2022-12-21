using AppManager.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AppManager.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {       
        public IActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminModel model)
        {
            if((model.Account == "admin" && model.Password == "admin")
                || (model.Account == "staff" && model.Password == "staff"))
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, model.Account),                   
                };

                if(model.Account == "admin")
                {
                    claims.Add(new Claim(ClaimTypes.Role, "admin"));
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, "staff"));
                }
                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));
            }
            else
            {
                ViewBag.Error = "Tài khoản hoặc mật khẩu không chính xác";
                return Redirect("/admin/account/login");
            }
            var returnUrl = string.IsNullOrEmpty(model.ReturnUrl) ?"/admin/home/index" : model.ReturnUrl;

            return Redirect(returnUrl);
        }
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/admin/account/login");
        }
    }
}
