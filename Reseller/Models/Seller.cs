using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class Seller
    {
        public Seller()
        {
            ResellerOrders = new HashSet<ResellerOrder>();
        }

        public int SellerId { get; set; }
        public string SellerUserName { get; set; }
        public string SellerName { get; set; }
        public string PhoneSeller { get; set; }
        public int RoleId { get; set; }

        public virtual RoleUser Role { get; set; }
        public virtual ICollection<ResellerOrder> ResellerOrders { get; set; }
    }
}
