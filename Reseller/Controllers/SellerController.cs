using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reseller.Models;

namespace Reseller.Controllers
{
    public class SellerController : Controller
    {
        private ResellerContext resellerContext;

        public SellerController(ResellerContext _resellerContext)
        {
            resellerContext = _resellerContext;
        }
        

        public IActionResult AddSeller()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddSeller(Seller seller)
        {
            if (ModelState.IsValid)
            {
                resellerContext.Sellers.Add(seller);
                resellerContext.SaveChanges();
                

                return RedirectToAction("SellerList", seller);

            }
            else
            {
                return View(seller);
            }
            
        }

        public IActionResult UpdateSeller(int id)
        {
            Seller seller = resellerContext.Sellers.Find(id);
       
            return View(seller);
        }

        [HttpPost]
        public IActionResult UpdateSeller(Seller seller)
        {
            if (ModelState.IsValid)
            {
                resellerContext.Entry(seller).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                resellerContext.SaveChanges();
               

                return RedirectToAction("SellerList", seller);
            }
            else
            {
                return View(seller);
            }
        }

        public IActionResult SellerList()
        {
            return View(resellerContext.Sellers.ToList());
        }

        public IActionResult DeleteSeller(int id)
        {
            var seller = resellerContext.Sellers.Find(id);
            
            if (seller!= null)
            {
                resellerContext.Sellers.Remove(seller);
                resellerContext.SaveChanges();
            }
            return RedirectToAction("SellerList");
        }
    }
}
