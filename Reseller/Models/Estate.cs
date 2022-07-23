//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reseller.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estate()
        {
            this.ResellerOrder = new HashSet<ResellerOrder>();
        }
    
        public int EstateID { get; set; }
        public string EstateName { get; set; }
        public string EstatePrice { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> ECategoryID { get; set; }
    
        public virtual EstateCategory EstateCategory { get; set; }
        public virtual Location Location { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResellerOrder> ResellerOrder { get; set; }
    }
}