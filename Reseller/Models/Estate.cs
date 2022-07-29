using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class Estate
    {
        public Estate()
        {
            ResellerOrders = new HashSet<ResellerOrder>();
        }

        public int EstateId { get; set; }
        public string EstateName { get; set; }
        public string EstatePrice { get; set; }
        public byte[] EstatePicture { get; set; }
        public int StatusId { get; set; }
        public int LocationId { get; set; }
        public int EcategoryId { get; set; }

        public virtual EstateCategory Ecategory { get; set; }
        public virtual Location Location { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<ResellerOrder> ResellerOrders { get; set; }
    }
}
