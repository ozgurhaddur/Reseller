using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Reseller.Models
{
    public partial class Bill
    {
        public Bill()
        {
            ResellerOrders = new HashSet<ResellerOrder>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillId { get; set; }
        public int BillNo { get; set; }
        public string BillDate { get; set; }

        public virtual ICollection<ResellerOrder> ResellerOrders { get; set; }
    }
}
