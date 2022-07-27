using System;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId)
                    .ValueGeneratedNever()
                    .HasColumnName("AdminID");

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Admin__RoleID__4222D4EF");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.BillId)
                    .ValueGeneratedNever()
                    .HasColumnName("BillID");

                entity.Property(e => e.BillDate)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.ToTable("Buyer");

                entity.Property(e => e.BuyerId)
                    .ValueGeneratedNever()
                    .HasColumnName("BuyerID");

                entity.Property(e => e.BuyerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BuyerUserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneBuyer)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Buyers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Buyer__RoleID__6FE99F9F");
            });

            modelBuilder.Entity<Estate>(entity =>
            {
                entity.ToTable("Estate");

                entity.Property(e => e.EstateId)
                    .ValueGeneratedNever()
                    .HasColumnName("EstateID");

                entity.Property(e => e.EcategoryId).HasColumnName("ECategoryID");

                entity.Property(e => e.EstateName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EstatePrice)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Ecategory)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.EcategoryId)
                    .HasConstraintName("FK__Estate__ECategor__489AC854");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__Estate__Location__47A6A41B");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Estates)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__Estate__StatusID__46B27FE2");
            });

            modelBuilder.Entity<EstateCategory>(entity =>
            {
                entity.HasKey(e => e.EcategoryId)
                    .HasName("PK__EstateCa__4ACBB32C4E445BCD");

                entity.ToTable("EstateCategory");

                entity.Property(e => e.EcategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("ECategoryID");

                entity.Property(e => e.EstateCategory1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("EstateCategory");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("LocationID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Neighbourhood)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ResellerOrder>(entity =>
            {
                entity.HasKey(e => e.OrderNo)
                    .HasName("PK__Reseller__C3907C74BE08FC2D");

                entity.ToTable("ResellerOrder");

                entity.Property(e => e.OrderNo).ValueGeneratedNever();

                entity.Property(e => e.BillId).HasColumnName("BillID");

                entity.Property(e => e.BuyerId).HasColumnName("BuyerID");

                entity.Property(e => e.EstateId).HasColumnName("EstateID");

                entity.Property(e => e.OrderDate)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SellerId).HasColumnName("SellerID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.BillId)
                    .HasConstraintName("FK__ResellerO__BillI__0F2D40CE");

                entity.HasOne(d => d.Buyer)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.BuyerId)
                    .HasConstraintName("FK__ResellerO__Buyer__10216507");

                entity.HasOne(d => d.Estate)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.EstateId)
                    .HasConstraintName("FK__ResellerO__Estat__12FDD1B2");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK__ResellerO__Selle__11158940");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.ResellerOrders)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK__ResellerO__Vehic__1209AD79");
            });

            modelBuilder.Entity<RoleUser>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__RoleUser__8AFACE3A7193415C");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleInfo)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.ToTable("Seller");

                entity.Property(e => e.SellerId)
                    .ValueGeneratedNever()
                    .HasColumnName("SellerID");

                entity.Property(e => e.PhoneSeller)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SellerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SellerUserName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Sellers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Seller__RoleID__04E4BC85");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.StatusInfo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.StatusNo)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.Property(e => e.VehicleId)
                    .ValueGeneratedNever()
                    .HasColumnName("VehicleID");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.VcategoryId).HasColumnName("VCategoryID");

                entity.Property(e => e.VehicleModelName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VehiclePrice)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VehicleSituation)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VehicleYear)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__Vehicle__Locatio__37703C52");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__Vehicle__StatusI__367C1819");

                entity.HasOne(d => d.Vcategory)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VcategoryId)
                    .HasConstraintName("FK__Vehicle__VCatego__3864608B");
            });

            modelBuilder.Entity<VehicleCategory>(entity =>
            {
                entity.HasKey(e => e.VcategoryId)
                    .HasName("PK__VehicleC__A99D482D8DA3BBA3");

                entity.ToTable("VehicleCategory");

                entity.Property(e => e.VcategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("VCategoryID");

                entity.Property(e => e.VehicleCategory1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("VehicleCategory");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
