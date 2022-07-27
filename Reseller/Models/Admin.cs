using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Reseller.Models
{
    public partial class Admin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminId { get; set; }
        public string UserName { get; set; }
        public string AdminName { get; set; }
        public int? RoleId { get; set; }

        public virtual RoleUser Role { get; set; }
    }
}
