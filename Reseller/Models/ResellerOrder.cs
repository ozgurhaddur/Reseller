using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class ResellerOrder
    {
        public int OrderNo { get; set; }
        public string OrderDate { get; set; }
        public int? BillNo { get; set; }
        public int? BuyerId { get; set; }
        public int? SellerId { get; set; }
        public int? VehicleId { get; set; }
        public int? EstateId { get; set; }

        public virtual Bill BillNoNavigation { get; set; }
        public virtual Buyer Buyer { get; set; }
        public virtual Estate Estate { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
