using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reseller.Models;
using Microsoft.AspNetCore.Authorization;

namespace Reseller.Controllers
{
    
    public class VehicleController : Controller
    {
        private ResellerContext resellerContext;

        public VehicleController(ResellerContext _resellerContext)
        {
            resellerContext = _resellerContext;
        }
        [Authorize(Roles = "Seller,Admin")]
        public IActionResult AddVehicle()
        {

            return View();
        }
        [Authorize(Roles = "Seller,Admin")]
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
        [Authorize(Roles = "Seller,Admin")]
        public IActionResult UpdateVehicle(int id)
        {
            Vehicle vehicle = resellerContext.Vehicles.Find(id);

            return View(vehicle);
        }
        [Authorize(Roles = "Seller,Admin")]
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
        [Authorize(Roles = "Seller,Admin")]
        public IActionResult VehicleList()
        {
            return View(resellerContext.Vehicles.ToList());
        }
        [Authorize(Roles = "Seller,Admin")]
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
        [Authorize(Roles = "Buyer,Admin")]
        public IActionResult VehicleBucket()
        {
            return View(resellerContext.Vehicles.ToList());
        }
        
        

        [Authorize(Roles = "Buyer,Admin")]
        public IActionResult BuyVehicle(int id)
        {
            //Vehicle entity = _vehicles.FirstOrDefault((x => x.VehicleId == vehicle.VehicleId));
            //if (entity == null)
            //{
            //    _vehicles.Add(vehicle);
            //}

            Vehicle vehicle = resellerContext.Vehicles.Find(id);

            resellerContext.Vehicles.Add(vehicle);
            return RedirectToAction("BucketList", vehicle);
        }

        [Authorize(Roles = "Buyer,Admin")]
        public IActionResult BucketList(Vehicle vehicle)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            var entity = resellerContext.Vehicles.Find(vehicle.VehicleId);
            vehicles.Add(entity);
            return View(vehicles.ToList());
        }
        [Authorize(Roles = "Buyer,Admin")]
        public IActionResult RemoveVehicle(int id)
        {
            Vehicle vehicle = resellerContext.Vehicles.Find(id);

            if (vehicle != null)
            {
                resellerContext.Vehicles.Remove(vehicle);
            }

            return RedirectToAction("VehicleBucket");
        }
        //public void ClearVehicle()
        //{
        //    _vehicles.Clear();
        //}

        //public List<Vehicle> GetAllVehicles
        //{
        //    get { return _vehicles; }

        //}
    }
}

