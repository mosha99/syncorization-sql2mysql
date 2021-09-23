using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TestConsole.datamaster
{
    public partial class MasterSET2008Context : DbContext
    {
        public MasterSET2008Context()
        {
        }

        public MasterSET2008Context(DbContextOptions<MasterSET2008Context> options)
            : base(options)
        {
        }

        public virtual DbSet<VwBuy> VwBuys { get; set; }
        public virtual DbSet<VwBuyList> VwBuyLists { get; set; }
        public virtual DbSet<VwCompany> VwCompanies { get; set; }
        public virtual DbSet<VwCustomer> VwCustomers { get; set; }
        public virtual DbSet<VwProduct> VwProducts { get; set; }
        public virtual DbSet<VwStore> VwStores { get; set; }
        public virtual DbSet<WvSale> WvSales { get; set; }
        public virtual DbSet<WvSaleList> WvSaleLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MasterSET2008;Persist Security Info=True;User ID=sa;Password=moein1381;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<VwBuy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Buy");

                entity.Property(e => e.BuyDate).HasMaxLength(10);

                entity.Property(e => e.Cheque).HasColumnName("cheque");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Editor).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<VwBuyList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BuyList");

                entity.Property(e => e.AccountId).HasColumnName("ACCountID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.BuyDate).HasMaxLength(10);

                entity.Property(e => e.BuyId).HasColumnName("BuyID");

                entity.Property(e => e.BuyTime).HasMaxLength(8);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.Store).HasMaxLength(50);
            });

            modelBuilder.Entity<VwCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Company");

                entity.Property(e => e.Company).HasMaxLength(50);
            });

            modelBuilder.Entity<VwCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Customer");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .HasColumnName("ADRESs");

                entity.Property(e => e.Mobil).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(100);
            });

            modelBuilder.Entity<VwProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StoreName).HasMaxLength(50);

                entity.Property(e => e.StroeId).HasColumnName("StroeID");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<VwStore>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Store");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WvSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wv_Sale");

                entity.Property(e => e.Cheque).HasColumnName("cheque");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.Editor).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SaleDate).HasMaxLength(10);

                entity.Property(e => e.Vat).HasColumnName("VAT");
            });

            modelBuilder.Entity<WvSaleList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wv_SaleList");

                entity.Property(e => e.AccountId).HasColumnName("ACCountID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.SaleDate).HasMaxLength(10);

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.SaleTime).HasMaxLength(8);

                entity.Property(e => e.Store).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
