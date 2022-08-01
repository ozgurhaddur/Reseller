using Microsoft.AspNetCore.Mvc;
using Reseller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reseller.Controllers
{
    
    public class RoleController : Controller
    {
        private ResellerContext resellerContext;

        public RoleController(ResellerContext _resellerContext)
        {
            resellerContext = _resellerContext;
        }


        public IActionResult AddRole()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddRole(RoleUser role)
        {
            if (ModelState.IsValid)
            {

                resellerContext.RoleUsers.Add(role);

                resellerContext.SaveChanges();




                return RedirectToAction("RoleList", role);

            }
            else
            {
                return View(role);
            }

        }

        public IActionResult UpdateRole(int id)
        {
            RoleUser role = resellerContext.RoleUsers.Find(id);

            return View(role);
        }

        [HttpPost]
        public IActionResult UpdateRole(RoleUser role)
        {
            if (ModelState.IsValid)
            {
                resellerContext.Entry(role).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                resellerContext.SaveChanges();


                return RedirectToAction("RoleList", role);
            }
            else
            {
                return View(role);
            }
        }

        public IActionResult RoleList()
        {
            return View(resellerContext.RoleUsers.ToList());
        }

        public IActionResult DeleteRole(int id)
        {
            var role  = resellerContext.RoleUsers.Find(id);

            if (role != null)
            {
                resellerContext.RoleUsers.Remove(role);
                resellerContext.SaveChanges();
            }
            return RedirectToAction("RoleList");
        }

    }
}
