using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class Bill
    {
        public Bill()
        {
            ResellerOrders = new HashSet<ResellerOrder>();
        }

        public int BillNo { get; set; }
        public string BillDate { get; set; }

        public virtual ICollection<ResellerOrder> ResellerOrders { get; set; }
    }
}
