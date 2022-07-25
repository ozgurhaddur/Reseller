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
        public string VehicleName { get; set; }
        public string BrandName { get; set; }
        public string VehicleYear { get; set; }
        public string VehicleModelName { get; set; }
        public string VehicleSituation { get; set; }
        public string FuelType { get; set; }
        public string VehiclePrice { get; set; }
        public int? StatusId { get; set; }
        public int? LocationId { get; set; }
        public int? VcategoryId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Status Status { get; set; }
        public virtual VehicleCategory Vcategory { get; set; }
        public virtual ICollection<ResellerOrder> ResellerOrders { get; set; }
    }
}
