using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Reseller.Models
{
    public partial class ResellerContext : DbContext
    {
        public ResellerContext()
        {
        }

        public ResellerContext(DbContextOptions<ResellerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Estate> Estates { get; set; }
        public virtual DbSet<EstateCategory> EstateCategories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<ResellerOrder> ResellerOrders { get; set; }
        public virtual DbSet<RoleUser> RoleUsers { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleCategory> VehicleCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Reseller;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .IsClustered(false);

                entity.ToTable("Admin");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admin_RoleUsers");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.BillNo)
                    .IsClustered(false);

                entity.ToTable("Bill");

                entity.Property(e => e.BillDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.HasKey(e => e.BuyerId)
                    .IsClustered(false);

                entity.ToTable("Buyer");

                entity.Property(e => e.BuyerId).HasColumnName("BuyerID");

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.BuyerUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneBuyer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Buyers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Buyer_RoleUsers");
            });

            modelBuilder.Entity<Estate>(entity =>
            {
                entity.HasKey(e => e.EstateId)
                    .IsClustered(false);

                entity.ToTable("Estate");

                entity.Property(e => e.EstateId).HasColumnName("EstateID");

                entity.Property(e => e.EcategoryId).HasColumnName("ECategoryID");

                entity.Property(e => e.EstateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.EstatePicture).IsRequired();

                entity.Property(e => e.EstatePrice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Ecategory)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.EcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estate_EstateCategory");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estate_Location");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estate_Status");
            });

            modelBuilder.Entity<EstateCategory>(entity =>
            {
                entity.HasKey(e => e.EcategoryId)
                    .IsClustered(false);

                entity.ToTable("EstateCategory");

                entity.Property(e => e.EcategoryId).HasColumnName("ECategoryID");

                entity.Property(e => e.EstateCategory1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EstateCategory")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .IsClustered(false);

                entity.ToTable("Location");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Neighbourhood)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ResellerOrder>(entity =>
            {
                entity.HasKey(e => e.OrderNo)
                    .IsClustered(false);

                entity.ToTable("ResellerOrder");

                entity.Property(e => e.BuyerId).HasColumnName("BuyerID");

                entity.Property(e => e.EstateId).HasColumnName("EstateID");

                entity.Property(e => e.OrderDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.SellerId).HasColumnName("SellerID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.BillNoNavigation)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.BillNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResellerOrder_Bill");

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.BuyerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResellerOrder_Buyer");

                entity.HasOne(d => d.Estate)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.EstateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResellerOrder_Estate");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResellerOrder_Seller");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResellerOrder_Vehicle");
            });

            modelBuilder.Entity<RoleUser>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_Role")
                    .IsClustered(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasKey(e => e.SellerId)
                    .IsClustered(false);

                entity.ToTable("Seller");

                entity.Property(e => e.SellerId).HasColumnName("SellerID");

                entity.Property(e => e.PhoneSeller)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SellerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.SellerUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Sellers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seller_RoleUsers");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .IsClustered(false);

                entity.ToTable("Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusInfo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .IsClustered(false);

                entity.ToTable("Vehicle");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.VcategoryId).HasColumnName("VCategoryID");

                entity.Property(e => e.VehicleModelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.VehiclePicture).IsRequired();

                entity.Property(e => e.VehiclePrice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.VehicleSituation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.VehicleYear)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_Location");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_Status");

                entity.HasOne(d => d.Vcategory)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_VehicleCategory");
            });

            modelBuilder.Entity<VehicleCategory>(entity =>
            {
                entity.HasKey(e => e.VcategoryId)
                    .IsClustered(false);

                entity.ToTable("VehicleCategory");

                entity.Property(e => e.VcategoryId).HasColumnName("VCategoryID");

                entity.Property(e => e.VehicleCategory1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VehicleCategory")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
