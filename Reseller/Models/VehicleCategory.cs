using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class VehicleCategory
    {
        public VehicleCategory()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int VcategoryId { get; set; }
        public string VehicleCategory1 { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
