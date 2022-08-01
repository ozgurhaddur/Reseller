using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Reseller.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var name = User.Claims.Where(c => c.Type == ClaimTypes.Name)
              .Select(c => c.Value).SingleOrDefault();
            return View();
        }
    }
}
