﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Reseller.Models
{
    public partial class Status
    {
        public Status()
        {
            Estates = new HashSet<Estate>();
            Vehicles = new HashSet<Vehicle>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StatusId { get; set; }
        public string StatusNo { get; set; }
        public string StatusInfo { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
