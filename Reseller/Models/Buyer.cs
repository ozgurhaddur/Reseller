using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class Buyer
    {
        public Buyer()
        {
            ResellerOrders = new HashSet<ResellerOrder>();
        }

        public int BuyerId { get; set; }
        public string BuyerUserName { get; set; }
        public string BuyerName { get; set; }
        public string PhoneBuyer { get; set; }
        public int RoleId { get; set; }

        public virtual RoleUser Role { get; set; }
        public virtual ICollection<ResellerOrder> ResellerOrders { get; set; }
    }
}
