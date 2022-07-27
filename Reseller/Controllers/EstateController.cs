using Microsoft.AspNetCore.Mvc;
using Reseller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reseller.Controllers
{
    public class EstateController : Controller
    {
        
            private ResellerContext resellerContext;

            public EstateController(ResellerContext _resellerContext)
            {
                resellerContext = _resellerContext;
            }
            public IActionResult AddEstate()
            {

                return View();
            }

            [HttpPost]
            public IActionResult AddEstate(Estate estate)
            {
                if (ModelState.IsValid)
                {
                    resellerContext.Estates.Add(estate);
                    resellerContext.SaveChanges();

                    return RedirectToAction("EstateList", estate);

                }
                else
                {
                    return View(estate);
                }


            }

            public IActionResult UpdateEstate(int id)
            {
                Estate estate = resellerContext.Estates.Find(id);

                return View(estate);
            }

            [HttpPost]
            public IActionResult UpdateEstate(Estate estate)
            {
                if (ModelState.IsValid)
                {
                    resellerContext.Entry(estate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    resellerContext.SaveChanges();


                    return RedirectToAction("EstateList", estate);
                }
                else
                {
                    return View(estate);
                }
            }

            public IActionResult EstateList()
            {
                return View(resellerContext.Estates.ToList());
            }

            public IActionResult DeleteEstate(int id)
            {

                var estate = resellerContext.Estates.Find(id);

                if (estate!= null)
                {
                    resellerContext.Estates.Remove(estate);
                    resellerContext.SaveChanges();
                }
                return RedirectToAction("EstateList");
            }
        }
    }

