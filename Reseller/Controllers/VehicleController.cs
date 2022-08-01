using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reseller.Models;
using Microsoft.AspNetCore.Authorization;

namespace Reseller.Controllers
{
    [Authorize(Roles = "Seller")]
    public class VehicleController : Controller
    {
        private ResellerContext resellerContext;

        public VehicleController(ResellerContext _resellerContext)
        {
            resellerContext = _resellerContext;
        }
        public IActionResult AddVehicle()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddVehicle(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                resellerContext.Vehicles.Add(vehicle);
                resellerContext.SaveChanges();

                return RedirectToAction("VehicleList", vehicle);

            }
            else
            {
                return View(vehicle);
            }


        }

        public IActionResult UpdateVehicle(int id)
        {
            Vehicle vehicle = resellerContext.Vehicles.Find(id);

            return View(vehicle);
        }

        [HttpPost]
        public IActionResult UpdateVehicle(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                resellerContext.Entry(vehicle).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                resellerContext.SaveChanges();


                return RedirectToAction("VehicleList", vehicle);
            }
            else
            {
                return View(vehicle);
            }
        }

        public IActionResult VehicleList()
        {
            return View(resellerContext.Vehicles.ToList());
        }

        public IActionResult DeleteVehicle(int id)
        {

            var vehicle = resellerContext.Vehicles.Find(id);

            if (vehicle != null)
            {
                resellerContext.Vehicles.Remove(vehicle);
                resellerContext.SaveChanges();
            }
            return RedirectToAction("VehicleList");
        }
    }
}

