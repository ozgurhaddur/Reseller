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

    public class AccountController : Controller
    {
    //    public List<LoginModel> users = null;
    //    public AccountController()
    //    {
    //        users = new List<LoginModel>();
    //        users.Add(new LoginModel()
    //        {
    //            LoginId = 1,
    //            Username = "adminname",
    //            Password = "12345",
    //            Role = "Admin"
    //        });
    //        users.Add(new LoginModel()
    //        {
    //            LoginId = 2,
    //            Username = "sellername",
    //            Password = "12345",
    //            Role = "Seller"
    //        });
    //        users.Add(new LoginModel()
    //        {
    //            LoginId = 2,
    //            Username = "buyername",
    //            Password = "12345",
    //            Role = "Buyer"
    //        });
    //    }
    //    [AllowAnonymous]
    //    public IActionResult Login(string ReturnUrl = "/Account/Login")
    //    {
    //        LoginModel objLoginModel = new LoginModel();
    //        objLoginModel.ReturnUrl = ReturnUrl;
    //        return View(objLoginModel);
    //    }
    //    [HttpPost]
    //    public async Task<IActionResult> Login(LoginModel objLoginModel)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            var user = users.Where(x => x.Username == objLoginModel.Username && x.Password == objLoginModel.Password).FirstOrDefault();
    //            if (user == null)
    //            {
    //                //Add logic here to display some message to user    
    //                ViewBag.Message = "Invalid Credential";
    //                return View(objLoginModel);
    //            }
    //            else
    //            {
    //                //A claim is a statement about a subject by an issuer and    
    //                //represent attributes of the subject that are useful in the context of authentication and authorization operations.    
    //                var claims = new List<Claim>() {
    //                new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.LoginId)),
    //                    new Claim(ClaimTypes.Name, user.Username),
    //                    new Claim(ClaimTypes.Role, user.Role)
    //            };
    //                //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme    
    //                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
    //                //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
    //                var principal = new ClaimsPrincipal(identity);
    //                //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
    //                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
    //                {
    //                    IsPersistent = objLoginModel.RememberMe
    //                });
    //                return LocalRedirect("/Home/Index");
    //            }
    //        }
    //        return View(objLoginModel);
    //    }
    //    [AllowAnonymous]
    //    public async Task<IActionResult> LogOut()
    //    {
    //        //SignOutAsync is Extension method for SignOut    
    //        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    //        //Redirect to home page    
    //        return LocalRedirect("/Account/Login");
    //    }
    }
}
