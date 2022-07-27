using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Reseller.Models
{
    public partial class RoleUser
    {
        public RoleUser()
        {
            Admins = new HashSet<Admin>();
            Buyers = new HashSet<Buyer>();
            Sellers = new HashSet<Seller>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleInfo { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Buyer> Buyers { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
    }
}
