﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Reseller.Models
{
    public partial class Location
    {
        public Location()
        {
            Estates = new HashSet<Estate>();
            Vehicles = new HashSet<Vehicle>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Neighbourhood { get; set; }
        public string Street { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
