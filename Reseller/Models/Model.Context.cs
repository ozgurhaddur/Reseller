﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ResellerEntities : DbContext
    {
        public ResellerEntities()
            : base("name=ResellerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Estate> Estate { get; set; }
        public virtual DbSet<EstateCategory> EstateCategory { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<ResellerOrder> ResellerOrder { get; set; }
        public virtual DbSet<RoleUsers> RoleUsers { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleCategory> VehicleCategory { get; set; }
    }
}