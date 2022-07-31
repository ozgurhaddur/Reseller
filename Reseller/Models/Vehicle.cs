using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            ResellerOrders = new HashSet<ResellerOrder>();
        }

        public int VehicleId { get; set; }
        public string VehicleCategory { get; set; }
        public string VehicleName { get; set; }
        public string BrandName { get; set; }
        public string VehicleYear { get; set; }
        public string VehicleModelName { get; set; }
        public string City { get; set; }
        public string LocationName { get; set; }
        public string VehicleSituation { get; set; }
        public string FuelType { get; set; }
        public string VehiclePrice { get; set; }
        public string VehiclePicture { get; set; }
        public string StatusInfo { get; set; }

        public virtual ICollection<ResellerOrder> ResellerOrders { get; set; }
    }
}
