using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string AdminName { get; set; }
        public int RoleId { get; set; }

        public virtual RoleUser Role { get; set; }
    }
}
