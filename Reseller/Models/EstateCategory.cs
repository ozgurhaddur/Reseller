using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Reseller.Models
{
    public partial class EstateCategory
    {
        public EstateCategory()
        {
            Estates = new HashSet<Estate>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EcategoryId { get; set; }
        public string EstateCategory1 { get; set; }

        public virtual ICollection<Estate> Estates { get; set; }
    }
}
