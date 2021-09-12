using System;
using System.IO;
using DataEditor.Models;
using DataEditor.myClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;

#nullable disable

namespace datamaster
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
                seting myseting = new seting();
                string path3 = "App_Data/seting.txt";
                using (StreamReader JsonText = new StreamReader(path3, true))
                {

                    string Jsonstring = JsonText.ReadToEnd();
                    var serverSettings = JsonConvert.DeserializeObject<seting>(Jsonstring,
                    new JsonSerializerSettings());
                    if (serverSettings != null)
                    {
                        myseting = serverSettings;
                    }
                    JsonText.Close();

                }
                string cs = $"Data Source={myseting.DbSuorse};Persist Security Info=True;Initial Catalog={myseting.DbName};User ID={myseting.SqlUsername };Password={myseting.SqlPassword};";
                Console.WriteLine(cs);

                optionsBuilder.UseSqlServer(cs);

                //TextEditor text = new TextEditor("App_Data/MS.txt");
                //string cs = text.Reader();




                Console.WriteLine(cs);
                optionsBuilder.UseSqlServer(cs); 

                Console.WriteLine("StartLog ********************************************************************");
                optionsBuilder.LogTo(Console.WriteLine);
                Console.WriteLine("EndLog ********************************************************************");
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
