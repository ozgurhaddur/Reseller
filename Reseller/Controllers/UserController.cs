using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reseller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Reseller.Controllers
{
    public class UserController : Controller
    {
        private ResellerContext db;

        public UserController(ResellerContext db)
        {
            this.db = db;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user.Username = model.Username;
                user.Password = model.Password;
                user.Roles = "Buyer,";

                db.Users.Add(user);
                db.SaveChanges();

                ViewData["message"] = "User created successfully!";
            }
            return View();
        }

        public IActionResult Login(string returnUrl)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model,
        string returnUrl)
        {
            bool isUservalid = false;

            User user = db.Users.Where(usr =>
        usr.Username == model.Username &&
        usr.Password == model.Password).SingleOrDefault();

            if (user != null)
            {
                isUservalid = true;
            }


            if (ModelState.IsValid && isUservalid)
            {
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.Name, user.Username));
                //claims.Add(new Claim(ClaimTypes.Role, user.Roles));

                string[] roles = user.Roles.Split(",");

                foreach (string role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                };

                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.
        AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();
                props.IsPersistent = model.RememberMe;

                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.
        AuthenticationScheme,
                    principal, props).Wait();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["message"] = "Invalid Username or Password!";
            }

            return View();
        }


        [AllowAnonymous]
        public async Task<IActionResult> LogOut()
        {
            //SignOutAsync is Extension method for SignOut    
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //Redirect to home page    
            return LocalRedirect("/User/Login");
        }

        [Authorize]
        public IActionResult Index()
        {
            string userName = HttpContext.User.Identity.Name;

            if (HttpContext.User.IsInRole("Admin"))
            {
                ViewData["adminMessage"] = "Hoşgeldiniz Admin!";
            }

            if (HttpContext.User.IsInRole("Seller"))
            {
                ViewData["sellerMessage"] = "Hoşgeldiniz Satıcı!";
            }

            if (HttpContext.User.IsInRole("Buyer"))
            {
                ViewData["buyerMessage"] = "Hoşgeldiniz Alıcı!";
            }

            ViewData["username"] = userName;

            return View();
        }
    }
}
