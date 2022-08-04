using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Seller,Admin")]
        public IActionResult AddEstate()
            {

                return View();
            }
        [Authorize(Roles = "Seller,Admin")]
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

        [Authorize(Roles = "Seller,Admin")]
        public IActionResult UpdateEstate(int id)
            {
                Estate estate = resellerContext.Estates.Find(id);

                return View(estate);
            }

        [Authorize(Roles = "Seller,Admin")]
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

        [Authorize(Roles = "Seller,Admin")]
        public IActionResult EstateList()
            {
                return View(resellerContext.Estates.ToList());
            }

        [Authorize(Roles = "Seller,Admin")]
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


        [Authorize(Roles = "Buyer,Admin")]
        public IActionResult EstateBucket()
        {

            return View(resellerContext.Estates.ToList());
        }
        

        //List<Estate> _estates = new List<Estate>();

        [Authorize(Roles = "Buyer,Admin")]
        public IActionResult BuyEstate(int id)
        {
            //Estate entity = _estates.Find((x => x.EstateId == estate.EstateId));
            //_estates.Add(entity);
            Estate estate = resellerContext.Estates.Find(id);

            resellerContext.Estates.Add(estate);

            return RedirectToAction("EstateBucketList", estate);
        }

        [Authorize(Roles = "Buyer,Admin")]
        public IActionResult EstateBucketList(Estate estate)
        {
            List<Estate> estates = new List<Estate>();
            var entity = resellerContext.Estates.Find(estate.EstateId);
            estates.Add(entity);
            return View(estates.ToList());
        }

        [Authorize(Roles = "Buyer,Admin")]
        public IActionResult RemoveEstate(int id)
        {
            //_estates.RemoveAll((x => x.EstateId == estate.EstateId));
            //Estate entity = _estates.FirstOrDefault((x => x.EstateId == estate.EstateId));
            //if (entity! == null)
            //{
            //    _estates.Remove(estate);
            //}
            Estate estate = resellerContext.Estates.Find(id);

            if (estate != null)
            {
                resellerContext.Estates.Remove(estate);
            }

            return RedirectToAction("EstateBucket");
        }
        //public void ClearEstate()
        //{
        //    _estates.Clear();
        //}

        //public List<Estate> GetAllEstates
        //{
        //    get { return _estates; }

        //}
    }
    }

