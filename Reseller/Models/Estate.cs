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
        public string EstateCategory { get; set; }
        public string EstateName { get; set; }
        public string EstateInfo { get; set; }
        public string City { get; set; }
        public string LocationName { get; set; }
        public string EstatePrice { get; set; }
        public string EstatePicture { get; set; }
        public string StatusInfo { get; set; }

        public virtual ICollection<ResellerOrder> ResellerOrders { get; set; }
    }
}
