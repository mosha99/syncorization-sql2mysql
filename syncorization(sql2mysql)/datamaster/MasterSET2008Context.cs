using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

        public virtual DbSet<Ag2> Ag2s { get; set; }
        public virtual DbSet<Ag3> Ag3s { get; set; }
        public virtual DbSet<Agl> Agls { get; set; }
        public virtual DbSet<Aglkhad> Aglkhads { get; set; }
        public virtual DbSet<Aglkhad2> Aglkhad2s { get; set; }
        public virtual DbSet<Anb> Anbs { get; set; }
        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<Cal> Cals { get; set; }
        public virtual DbSet<Chd> Chds { get; set; }
        public virtual DbSet<Chd2> Chd2s { get; set; }
        public virtual DbSet<Chp> Chps { get; set; }
        public virtual DbSet<Col> Cols { get; set; }
        public virtual DbSet<Company2> Company2s { get; set; }
        public virtual DbSet<Custom> Customs { get; set; }
        public virtual DbSet<CustomTfprint> CustomTfprints { get; set; }
        public virtual DbSet<DbInfo> DbInfos { get; set; }
        public virtual DbSet<Fac> Facs { get; set; }
        public virtual DbSet<FactorDelivery> FactorDeliveries { get; set; }
        public virtual DbSet<Ffo> Ffos { get; set; }
        public virtual DbSet<Ffoa> Ffoas { get; set; }
        public virtual DbSet<Fkh> Fkhs { get; set; }
        public virtual DbSet<Fkha> Fkhas { get; set; }
        public virtual DbSet<Fkhad> Fkhads { get; set; }
        public virtual DbSet<Fto0> Fto0s { get; set; }
        public virtual DbSet<Fto2> Fto2s { get; set; }
        public virtual DbSet<Fto3> Fto3s { get; set; }
        public virtual DbSet<Ftol> Ftols { get; set; }
        public virtual DbSet<Ftum> Fta { get; set; }
        public virtual DbSet<Ge> Ges { get; set; }
        public virtual DbSet<Ge0> Ge0s { get; set; }
        public virtual DbSet<Ge2> Ge2s { get; set; }
        public virtual DbSet<He> Hes { get; set; }
        public virtual DbSet<Ho0> Ho0s { get; set; }
        public virtual DbSet<Ho2> Ho2s { get; set; }
        public virtual DbSet<Hog> Hogs { get; set; }
        public virtual DbSet<Kark> Karks { get; set; }
        public virtual DbSet<Karkfor> Karkfors { get; set; }
        public virtual DbSet<Kart> Karts { get; set; }
        public virtual DbSet<Kformula> Kformulas { get; set; }
        public virtual DbSet<Khad> Khads { get; set; }
        public virtual DbSet<Mfo> Mfos { get; set; }
        public virtual DbSet<Mkh> Mkhs { get; set; }
        public virtual DbSet<Mo> Mos { get; set; }
        public virtual DbSet<Moe> Moes { get; set; }
        public virtual DbSet<Moz> Mozs { get; set; }
        public virtual DbSet<Moz2> Moz2s { get; set; }
        public virtual DbSet<Pfa> Pfas { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Ra> Ras { get; set; }
        public virtual DbSet<RasD> RasDs { get; set; }
        public virtual DbSet<Sa0> Sa0s { get; set; }
        public virtual DbSet<Sa2> Sa2s { get; set; }
        public virtual DbSet<Sa3> Sa3s { get; set; }
        public virtual DbSet<SalMaly> SalMalies { get; set; }
        public virtual DbSet<San> Sans { get; set; }
        public virtual DbSet<Sherkat> Sherkats { get; set; }
        public virtual DbSet<Shobe> Shobes { get; set; }
        public virtual DbSet<SodZian> SodZians { get; set; }
        public virtual DbSet<Spy> Spies { get; set; }
        public virtual DbSet<Taf> Tafs { get; set; }
        public virtual DbSet<Tafcal> Tafcals { get; set; }
        public virtual DbSet<Tan> Tans { get; set; }
        public virtual DbSet<TarDb> TarDbs { get; set; }
        public virtual DbSet<TarzT> TarzTs { get; set; }
        public virtual DbSet<TbSysCurrency> TbSysCurrencies { get; set; }
        public virtual DbSet<TbSysFeildDataDictionary> TbSysFeildDataDictionaries { get; set; }
        public virtual DbSet<TbSysForm> TbSysForms { get; set; }
        public virtual DbSet<TbSysFormFeildDataDictionary> TbSysFormFeildDataDictionaries { get; set; }
        public virtual DbSet<TbSysGroup> TbSysGroups { get; set; }
        public virtual DbSet<TbSysPackage> TbSysPackages { get; set; }
        public virtual DbSet<TbSysPackageForm> TbSysPackageForms { get; set; }
        public virtual DbSet<TbSysStatus> TbSysStatuses { get; set; }
        public virtual DbSet<TbSysTableDataDictionary> TbSysTableDataDictionaries { get; set; }
        public virtual DbSet<Tel> Tels { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDatum> UserData { get; set; }
        public virtual DbSet<Vah> Vahs { get; set; }
        public virtual DbSet<Vizitor> Vizitors { get; set; }
        public virtual DbSet<VwBuy> VwBuys { get; set; }
        public virtual DbSet<VwBuyList> VwBuyLists { get; set; }
        public virtual DbSet<VwCompany> VwCompanies { get; set; }
        public virtual DbSet<VwCustomer> VwCustomers { get; set; }
        public virtual DbSet<VwProduct> VwProducts { get; set; }
        public virtual DbSet<VwProductFa> VwProductFas { get; set; }
        public virtual DbSet<VwStore> VwStores { get; set; }
        public virtual DbSet<VwStoreFa> VwStoreFas { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }
        public virtual DbSet<WvSale> WvSales { get; set; }
        public virtual DbSet<WvSaleList> WvSaleLists { get; set; }
        public virtual DbSet<Yad> Yads { get; set; }
        public virtual DbSet<ZTempAgl> ZTempAgls { get; set; }
        public virtual DbSet<ZTempFfo> ZTempFfos { get; set; }
        public virtual DbSet<ZTempFkh> ZTempFkhs { get; set; }
        public virtual DbSet<ZTempGetMojCala> ZTempGetMojCalas { get; set; }
        public virtual DbSet<ZTempReportAmlkardDaru> ZTempReportAmlkardDarus { get; set; }
        public virtual DbSet<ZTempReportCol> ZTempReportCols { get; set; }
        public virtual DbSet<ZTempReportQcal> ZTempReportQcals { get; set; }
        public virtual DbSet<ZTempReportSa0> ZTempReportSa0s { get; set; }
        public virtual DbSet<ZTempReportTaz> ZTempReportTazs { get; set; }
        public virtual DbSet<ZTempSa0> ZTempSa0s { get; set; }
        public virtual DbSet<ZTempSan> ZTempSans { get; set; }

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

            modelBuilder.Entity<Ag2>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.NoeF, e.Cod, e.Rad });

                entity.ToTable("Ag2");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.NoeF)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.Cod)
                    .HasColumnName("COD")
                    .HasComment("");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.AbadC)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD_C");

                entity.Property(e => e.Acronym2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Acronym3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BarcodC)
                    .HasMaxLength(100)
                    .HasColumnName("BARCOD_C");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodAnb2).HasColumnName("COD_ANB2");

                entity.Property(e => e.CodC)
                    .HasColumnName("COD_C")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcT).HasColumnName("cod_hc_t");

                entity.Property(e => e.CodHcVi).HasColumnName("cod_hc_vi");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmT).HasColumnName("cod_hm_t");

                entity.Property(e => e.CodHmVi).HasColumnName("cod_hm_vi");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Exchange2).HasDefaultValueSql("((1))");

                entity.Property(e => e.Exchange3).HasDefaultValueSql("((1))");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhMasC).HasColumnName("GH_MAS_C");

                entity.Property(e => e.GhMin).HasColumnName("GH_MIN");

                entity.Property(e => e.GhMinhaz).HasColumnName("GH_MINHAZ");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.GhNa2).HasColumnName("gh_na2");

                entity.Property(e => e.GhNa3).HasColumnName("gh_na3");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.GhZar).HasColumnName("GH_ZAR");

                entity.Property(e => e.Guaranty).HasColumnName("GUARANTY");

                entity.Property(e => e.Haz).HasColumnName("haz");

                entity.Property(e => e.MojC).HasColumnName("MOJ_C");

                entity.Property(e => e.MojFifo).HasColumnName("MOJ_FIFO");

                entity.Property(e => e.MojLifo).HasColumnName("MOJ_LIFO");

                entity.Property(e => e.MojZ).HasColumnName("MOJ_Z");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.NameAnb2)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB2");

                entity.Property(e => e.NameC)
                    .HasMaxLength(100)
                    .HasColumnName("NAME_C");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.Noecal)
                    .HasMaxLength(50)
                    .HasColumnName("NOECAL");

                entity.Property(e => e.Ranandeh)
                    .HasMaxLength(254)
                    .HasColumnName("RANANDEH");

                entity.Property(e => e.Shg1).HasColumnName("shg1");

                entity.Property(e => e.Shg2).HasColumnName("shg2");

                entity.Property(e => e.Shom)
                    .HasMaxLength(254)
                    .HasColumnName("SHOM");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(254)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.TakhC).HasColumnName("TAKH_C");

                entity.Property(e => e.TakhTedC).HasColumnName("TAKH_TED_C");

                entity.Property(e => e.TarC)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_C");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarTo)
                    .HasMaxLength(10)
                    .HasColumnName("tar_to");

                entity.Property(e => e.TedC).HasColumnName("TED_C");

                entity.Property(e => e.TimeC)
                    .HasMaxLength(8)
                    .HasColumnName("TIME_C");

                entity.Property(e => e.Tozih2C)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH2_C");

                entity.Property(e => e.TozihC)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_C");

                entity.Property(e => e.TozihEng)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_ENG");

                entity.Property(e => e.Vah2C)
                    .HasMaxLength(50)
                    .HasColumnName("VAH2_C");

                entity.Property(e => e.VahC)
                    .HasMaxLength(50)
                    .HasColumnName("VAH_C");

                entity.Property(e => e.ZarC).HasColumnName("ZAR_C");

                entity.Property(e => e.ZarCol).HasColumnName("ZAR_COL");
            });

            modelBuilder.Entity<Ag3>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.NoeF, e.Cod, e.Rad });

                entity.ToTable("Ag3");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.NoeF)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.AbadC)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD_C");

                entity.Property(e => e.Acronym2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Acronym3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BarcodC)
                    .HasMaxLength(100)
                    .HasColumnName("BARCOD_C");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodAnb2).HasColumnName("COD_ANB2");

                entity.Property(e => e.CodC).HasColumnName("COD_C");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcT).HasColumnName("cod_hc_t");

                entity.Property(e => e.CodHcVi).HasColumnName("cod_hc_vi");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmT).HasColumnName("cod_hm_t");

                entity.Property(e => e.CodHmVi).HasColumnName("cod_hm_vi");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Exchange2).HasDefaultValueSql("((1))");

                entity.Property(e => e.Exchange3).HasDefaultValueSql("((1))");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhMasC).HasColumnName("GH_MAS_C");

                entity.Property(e => e.GhMin).HasColumnName("GH_MIN");

                entity.Property(e => e.GhMinhaz).HasColumnName("GH_MINHAZ");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.GhNa2).HasColumnName("gh_na2");

                entity.Property(e => e.GhNa3).HasColumnName("gh_na3");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.GhZar).HasColumnName("GH_ZAR");

                entity.Property(e => e.Guaranty).HasColumnName("GUARANTY");

                entity.Property(e => e.Haz).HasColumnName("haz");

                entity.Property(e => e.MojC).HasColumnName("MOJ_C");

                entity.Property(e => e.MojFifo).HasColumnName("MOJ_FIFO");

                entity.Property(e => e.MojLifo).HasColumnName("MOJ_LIFO");

                entity.Property(e => e.MojZ).HasColumnName("MOJ_Z");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.NameAnb2)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB2");

                entity.Property(e => e.NameC)
                    .HasMaxLength(100)
                    .HasColumnName("NAME_C");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.Noecal)
                    .HasMaxLength(50)
                    .HasColumnName("NOECAL");

                entity.Property(e => e.Ranandeh)
                    .HasMaxLength(254)
                    .HasColumnName("RANANDEH");

                entity.Property(e => e.Shg1).HasColumnName("shg1");

                entity.Property(e => e.Shg2).HasColumnName("shg2");

                entity.Property(e => e.Shom)
                    .HasMaxLength(254)
                    .HasColumnName("SHOM");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(254)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.TakhC).HasColumnName("TAKH_C");

                entity.Property(e => e.TakhTedC).HasColumnName("TAKH_TED_C");

                entity.Property(e => e.TarC)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_C");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarTo)
                    .HasMaxLength(10)
                    .HasColumnName("tar_to");

                entity.Property(e => e.TedC).HasColumnName("TED_C");

                entity.Property(e => e.TimeC)
                    .HasMaxLength(8)
                    .HasColumnName("TIME_C");

                entity.Property(e => e.Tozih2C)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH2_C");

                entity.Property(e => e.TozihC)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_C");

                entity.Property(e => e.TozihEng)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_ENG");

                entity.Property(e => e.Vah2C)
                    .HasMaxLength(50)
                    .HasColumnName("VAH2_C");

                entity.Property(e => e.VahC)
                    .HasMaxLength(50)
                    .HasColumnName("VAH_C");

                entity.Property(e => e.ZarC).HasColumnName("ZAR_C");

                entity.Property(e => e.ZarCol).HasColumnName("ZAR_COL");
            });

            modelBuilder.Entity<Agl>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.NoeF, e.Cod, e.Rad });

                entity.ToTable("AGL");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.NoeF)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.AbadC)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD_C");

                entity.Property(e => e.Acronym2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Acronym3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BarcodC)
                    .HasMaxLength(100)
                    .HasColumnName("BARCOD_C");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodAnb2).HasColumnName("COD_ANB2");

                entity.Property(e => e.CodC).HasColumnName("COD_C");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcT).HasColumnName("cod_hc_t");

                entity.Property(e => e.CodHcVi).HasColumnName("cod_hc_vi");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmT).HasColumnName("cod_hm_t");

                entity.Property(e => e.CodHmVi).HasColumnName("cod_hm_vi");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Exchange2).HasDefaultValueSql("((1))");

                entity.Property(e => e.Exchange3).HasDefaultValueSql("((1))");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhMasC).HasColumnName("GH_MAS_C");

                entity.Property(e => e.GhMin).HasColumnName("GH_MIN");

                entity.Property(e => e.GhMinhaz).HasColumnName("GH_MINHAZ");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.GhNa2).HasColumnName("gh_na2");

                entity.Property(e => e.GhNa3).HasColumnName("gh_na3");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.GhZar).HasColumnName("GH_ZAR");

                entity.Property(e => e.Guaranty).HasColumnName("GUARANTY");

                entity.Property(e => e.Haz).HasColumnName("haz");

                entity.Property(e => e.MojC).HasColumnName("MOJ_C");

                entity.Property(e => e.MojFifo).HasColumnName("MOJ_FIFO");

                entity.Property(e => e.MojLifo).HasColumnName("MOJ_LIFO");

                entity.Property(e => e.MojZ).HasColumnName("MOJ_Z");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.NameAnb2)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB2");

                entity.Property(e => e.NameC)
                    .HasMaxLength(100)
                    .HasColumnName("NAME_C");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.Noecal)
                    .HasMaxLength(50)
                    .HasColumnName("NOECAL");

                entity.Property(e => e.Ranandeh)
                    .HasMaxLength(254)
                    .HasColumnName("RANANDEH");

                entity.Property(e => e.Shg1).HasColumnName("shg1");

                entity.Property(e => e.Shg2).HasColumnName("shg2");

                entity.Property(e => e.Shom)
                    .HasMaxLength(254)
                    .HasColumnName("SHOM");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(254)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.TakhC).HasColumnName("TAKH_C");

                entity.Property(e => e.TakhTedC).HasColumnName("TAKH_TED_C");

                entity.Property(e => e.TarC)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_C");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarTo)
                    .HasMaxLength(10)
                    .HasColumnName("tar_to");

                entity.Property(e => e.TedC).HasColumnName("TED_C");

                entity.Property(e => e.TimeC)
                    .HasMaxLength(8)
                    .HasColumnName("TIME_C");

                entity.Property(e => e.Tozih2C)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH2_C");

                entity.Property(e => e.TozihC)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_C");

                entity.Property(e => e.TozihEng)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_ENG");

                entity.Property(e => e.Vah2C)
                    .HasMaxLength(50)
                    .HasColumnName("VAH2_C");

                entity.Property(e => e.VahC)
                    .HasMaxLength(50)
                    .HasColumnName("VAH_C");

                entity.Property(e => e.ZarC).HasColumnName("ZAR_C");

                entity.Property(e => e.ZarCol).HasColumnName("ZAR_COL");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Agls)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_AGL_SalMaly");
            });

            modelBuilder.Entity<Aglkhad>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod, e.Rad });

                entity.ToTable("aglkhad");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.CodKhad).HasColumnName("COD_KHAD");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Ted).HasColumnName("TED");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(200)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Aglkhads)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_aglkhad_SalMaly");
            });

            modelBuilder.Entity<Aglkhad2>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.SpidHostName, e.Cod, e.Rad });

                entity.ToTable("aglkhad2");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.CodKhad).HasColumnName("COD_KHAD");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Ted).HasColumnName("TED");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(200)
                    .HasColumnName("TOZIH");
            });

            modelBuilder.Entity<Anb>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("ANB");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_ANB")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Adr)
                    .HasMaxLength(50)
                    .HasColumnName("adr");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.NoeAnbar).HasMaxLength(20);

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Anbs)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_ANB_SalMaly");
            });

            modelBuilder.Entity<Ban>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("BAN");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_BAN")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Bans)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_BAN_SalMaly");
            });

            modelBuilder.Entity<Cal>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("CAL");

                entity.HasIndex(e => new { e.ShsId, e.CodAnb, e.Name }, "IX_CAL")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Abad)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD");

                entity.Property(e => e.AbadAml)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD_AML");

                entity.Property(e => e.AbadHad)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD_HAD");

                entity.Property(e => e.AbadPish)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD_PISH");

                entity.Property(e => e.AbadZar)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD_ZAR");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Attribute1).HasMaxLength(50);

                entity.Property(e => e.Attribute2).HasMaxLength(50);

                entity.Property(e => e.Barcod)
                    .HasMaxLength(100)
                    .HasColumnName("BARCOD");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodHcT).HasColumnName("cod_hc_t");

                entity.Property(e => e.CodHmT).HasColumnName("cod_hm_t");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Darvizitor).HasColumnName("DARVIZITOR");

                entity.Property(e => e.FfoNoe)
                    .HasMaxLength(10)
                    .HasColumnName("ffo_noe");

                entity.Property(e => e.Garanti).HasColumnName("GARANTI");

                entity.Property(e => e.GhFo).HasColumnName("GH_FO");

                entity.Property(e => e.GhFoj).HasColumnName("GH_FOJ");

                entity.Property(e => e.GhFok).HasColumnName("GH_FOK");

                entity.Property(e => e.GhKh).HasColumnName("GH_KH");

                entity.Property(e => e.GhLastKh).HasColumnName("GH_LAST_KH");

                entity.Property(e => e.GhMas).HasColumnName("GH_MAS");

                entity.Property(e => e.GhMin).HasColumnName("GH_MIN");

                entity.Property(e => e.GhMojAv).HasColumnName("GH_MOJ_AV");

                entity.Property(e => e.GhRoz).HasColumnName("gh_roz");

                entity.Property(e => e.GhTmpMoj).HasColumnName("GH_TMP_MOJ");

                entity.Property(e => e.GhlastFo).HasColumnName("GHLAST_FO");

                entity.Property(e => e.HadTedffo).HasColumnName("HAD_TEDFFO");

                entity.Property(e => e.Hadfor).HasColumnName("HADFOR");

                entity.Property(e => e.Joz)
                    .HasMaxLength(254)
                    .HasColumnName("JOZ");

                entity.Property(e => e.Khad).HasColumnName("KHAD");

                entity.Property(e => e.MabNasbM).HasColumnName("MAB_NASB_M");

                entity.Property(e => e.MabNasbS).HasColumnName("MAB_NASB_S");

                entity.Property(e => e.Manufactory).HasMaxLength(50);

                entity.Property(e => e.Max).HasColumnName("MAX");

                entity.Property(e => e.Min).HasColumnName("MIN");

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Moj).HasColumnName("MOJ");

                entity.Property(e => e.MojAv).HasColumnName("MOJ_AV");

                entity.Property(e => e.MojZ).HasColumnName("MOJ_Z");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.NoeAnbar).HasMaxLength(20);

                entity.Property(e => e.Noecal)
                    .HasMaxLength(50)
                    .HasColumnName("NOECAL");

                entity.Property(e => e.PartSize).HasMaxLength(50);

                entity.Property(e => e.PartType).HasMaxLength(50);

                entity.Property(e => e.RozS).HasColumnName("ROZ_S");

                entity.Property(e => e.Selec).HasColumnName("SELEC");

                entity.Property(e => e.Shom)
                    .HasMaxLength(100)
                    .HasColumnName("SHOM");

                entity.Property(e => e.Shomareshi).HasColumnName("SHOMARESHI");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(500)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.Takh).HasColumnName("takh");

                entity.Property(e => e.TakhZar).HasColumnName("takh_zar");

                entity.Property(e => e.TarAv)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_AV");

                entity.Property(e => e.Tedad).HasColumnName("TEDAD");

                entity.Property(e => e.TmpMoj).HasColumnName("TMP_MOJ");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.TozihEng)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_ENG");

                entity.Property(e => e.Vah)
                    .HasMaxLength(50)
                    .HasColumnName("VAH");

                entity.Property(e => e.Vah2)
                    .HasMaxLength(50)
                    .HasColumnName("VAH2");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Zar).HasColumnName("ZAR");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Cals)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_CAL_SalMaly");
            });

            modelBuilder.Entity<Chd>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("CHD");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodFac).HasColumnName("COD_FAC");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodSad).HasColumnName("COD_SAD");

                entity.Property(e => e.CodSav).HasColumnName("COD_SAV");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Edg).HasColumnName("EDG");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.NameBa)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_BA");

                entity.Property(e => e.ShoBa)
                    .HasMaxLength(50)
                    .HasColumnName("SHO_BA");

                entity.Property(e => e.Shog)
                    .HasMaxLength(20)
                    .HasColumnName("SHOG");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.TarD)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_D");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.TbFac)
                    .HasMaxLength(10)
                    .HasColumnName("TB_FAC");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(50)
                    .HasColumnName("VAZ");

                entity.Property(e => e.Vazha)
                    .HasMaxLength(254)
                    .HasColumnName("VAZHA");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Chds)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_CHD_SalMaly");
            });

            modelBuilder.Entity<Chd2>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Cod });

                entity.ToTable("CHD2");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodSad).HasColumnName("COD_SAD");

                entity.Property(e => e.CodSav).HasColumnName("COD_SAV");

                entity.Property(e => e.Edg).HasColumnName("EDG");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.NameBa)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_BA");

                entity.Property(e => e.ShoBa)
                    .HasMaxLength(50)
                    .HasColumnName("SHO_BA");

                entity.Property(e => e.Shog)
                    .HasMaxLength(20)
                    .HasColumnName("SHOG");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.TarD)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_D");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<Chp>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("CHP");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodFac).HasColumnName("COD_FAC");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHe).HasColumnName("COD_HE");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodSap).HasColumnName("COD_SAP");

                entity.Property(e => e.CodSas).HasColumnName("COD_SAS");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Edg).HasColumnName("EDG");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.TarP)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_P");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.TbFac)
                    .HasMaxLength(10)
                    .HasColumnName("TB_FAC");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(50)
                    .HasColumnName("VAZ");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Chps)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_CHP_SalMaly");
            });

            modelBuilder.Entity<Col>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("COL");

                entity.HasIndex(e => new { e.ShsId, e.CodR, e.Name }, "IX_COL")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShsId, e.Coding }, "IX_COL_coding")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodR).HasColumnName("COD_R");

                entity.Property(e => e.Coding)
                    .HasMaxLength(50)
                    .HasColumnName("coding")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dargeh).HasColumnName("DARGEH");

                entity.Property(e => e.Mah)
                    .HasMaxLength(20)
                    .HasColumnName("MAH");

                entity.Property(e => e.MoDa).HasColumnName("MO_DA");

                entity.Property(e => e.Moe).HasColumnName("MOE");

                entity.Property(e => e.Moj).HasColumnName("MOJ");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Noe)
                    .HasMaxLength(15)
                    .HasColumnName("NOE");

                entity.Property(e => e.NoeEs)
                    .HasMaxLength(100)
                    .HasColumnName("NOE_ES");

                entity.Property(e => e.TmpMoj).HasColumnName("TMP_MOJ");

                entity.Property(e => e.TmpMojbs).HasColumnName("TMP_MOJBS");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Cols)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_COL_SalMaly");
            });

            modelBuilder.Entity<Company2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Company2");

                entity.Property(e => e.Expr1).HasMaxLength(82);
            });

            modelBuilder.Entity<Custom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Custom");

                entity.Property(e => e.Anbar).HasColumnName("ANBAR");

                entity.Property(e => e.Daghigh).HasColumnName("daghigh");

                entity.Property(e => e.Hesabm).HasColumnName("HESABM");

                entity.Property(e => e.Hint).HasMaxLength(255);

                entity.Property(e => e.Hogog).HasColumnName("hogog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Khazaneh).HasColumnName("KHAZANEH");

                entity.Property(e => e.Mashhad).HasColumnName("MASHHAD");

                entity.Property(e => e.Modirm).HasColumnName("MODIRM");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Path).HasMaxLength(255);

                entity.Property(e => e.Sadeh).HasColumnName("SADEH");

                entity.Property(e => e.Sandogh).HasColumnName("SANDOGh");
            });

            modelBuilder.Entity<CustomTfprint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomTFPrints");

                entity.Property(e => e.Anbar).HasColumnName("ANBAR");

                entity.Property(e => e.Daghigh).HasColumnName("daghigh");

                entity.Property(e => e.Hesabm).HasColumnName("HESABM");

                entity.Property(e => e.Hint).HasMaxLength(255);

                entity.Property(e => e.Hogog).HasColumnName("hogog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Khazaneh).HasColumnName("KHAZANEH");

                entity.Property(e => e.Mashhad).HasColumnName("MASHHAD");

                entity.Property(e => e.Modirm).HasColumnName("MODIRM");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Path).HasMaxLength(255);

                entity.Property(e => e.Sadeh).HasColumnName("SADEH");

                entity.Property(e => e.Sandogh).HasColumnName("SANDOGh");
            });

            modelBuilder.Entity<DbInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("db_info");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Fac>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.NoeF, e.Cod })
                    .HasName("PK_FFO");

                entity.ToTable("fac");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.NoeF)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcTas).HasColumnName("cod_hc_tas");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVas).HasColumnName("cod_hc_vas");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmN).HasColumnName("COD_HM_N");

                entity.Property(e => e.CodHmTas).HasColumnName("cod_hm_tas");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVas).HasColumnName("cod_hm_vas");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.DoAa).HasColumnName("Do_aa");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabTas).HasColumnName("mab_tas");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.PrintCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefF)
                    .HasMaxLength(50)
                    .HasColumnName("ref_f");

                entity.Property(e => e.RefHaz)
                    .HasMaxLength(50)
                    .HasColumnName("ref_haz");

                entity.Property(e => e.RefTas)
                    .HasMaxLength(50)
                    .HasColumnName("ref_tas");

                entity.Property(e => e.RefV)
                    .HasMaxLength(50)
                    .HasColumnName("ref_v");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Takh2).HasColumnName("takh2");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.Property(e => e.UpdateDate).HasMaxLength(17);

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Facs)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_FFO_SalMaly");
            });

            modelBuilder.Entity<FactorDelivery>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.NoeF, e.Cod, e.Rad });

                entity.ToTable("FactorDelivery");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.NoeF)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("rad");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CodC).HasColumnName("cod_c");

                entity.Property(e => e.Commnet)
                    .HasMaxLength(50)
                    .HasColumnName("commnet");

                entity.Property(e => e.DeliveryDate).HasMaxLength(10);

                entity.Property(e => e.DeliveryTime).HasMaxLength(8);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.FactorDeliveries)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_FactorDelivery_SalMaly");
            });

            modelBuilder.Entity<Ffo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ffo");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcTas).HasColumnName("cod_hc_tas");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVas).HasColumnName("cod_hc_vas");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmN).HasColumnName("COD_HM_N");

                entity.Property(e => e.CodHmTas).HasColumnName("cod_hm_tas");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVas).HasColumnName("cod_hm_vas");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.DoAa).HasColumnName("Do_aa");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabTas).HasColumnName("mab_tas");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.RefF)
                    .HasMaxLength(50)
                    .HasColumnName("ref_f");

                entity.Property(e => e.RefHaz)
                    .HasMaxLength(50)
                    .HasColumnName("ref_haz");

                entity.Property(e => e.RefTas)
                    .HasMaxLength(50)
                    .HasColumnName("ref_tas");

                entity.Property(e => e.RefV)
                    .HasMaxLength(50)
                    .HasColumnName("ref_v");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Takh2).HasColumnName("takh2");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(8)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.Property(e => e.UpdateDate).HasMaxLength(17);

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<Ffoa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ffoa");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcTas).HasColumnName("cod_hc_tas");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVas).HasColumnName("cod_hc_vas");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmN).HasColumnName("COD_HM_N");

                entity.Property(e => e.CodHmTas).HasColumnName("cod_hm_tas");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVas).HasColumnName("cod_hm_vas");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.DoAa).HasColumnName("Do_aa");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabTas).HasColumnName("mab_tas");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.RefF)
                    .HasMaxLength(50)
                    .HasColumnName("ref_f");

                entity.Property(e => e.RefHaz)
                    .HasMaxLength(50)
                    .HasColumnName("ref_haz");

                entity.Property(e => e.RefTas)
                    .HasMaxLength(50)
                    .HasColumnName("ref_tas");

                entity.Property(e => e.RefV)
                    .HasMaxLength(50)
                    .HasColumnName("ref_v");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Takh2).HasColumnName("takh2");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(8)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.Property(e => e.UpdateDate).HasMaxLength(17);

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<Fkh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("fkh");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcTas).HasColumnName("cod_hc_tas");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVas).HasColumnName("cod_hc_vas");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmN).HasColumnName("COD_HM_N");

                entity.Property(e => e.CodHmTas).HasColumnName("cod_hm_tas");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVas).HasColumnName("cod_hm_vas");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.DoAa).HasColumnName("Do_aa");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabTas).HasColumnName("mab_tas");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.RefF)
                    .HasMaxLength(50)
                    .HasColumnName("ref_f");

                entity.Property(e => e.RefHaz)
                    .HasMaxLength(50)
                    .HasColumnName("ref_haz");

                entity.Property(e => e.RefTas)
                    .HasMaxLength(50)
                    .HasColumnName("ref_tas");

                entity.Property(e => e.RefV)
                    .HasMaxLength(50)
                    .HasColumnName("ref_v");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Takh2).HasColumnName("takh2");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(8)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.Property(e => e.UpdateDate).HasMaxLength(17);

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<Fkha>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("fkha");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcTas).HasColumnName("cod_hc_tas");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVas).HasColumnName("cod_hc_vas");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmN).HasColumnName("COD_HM_N");

                entity.Property(e => e.CodHmTas).HasColumnName("cod_hm_tas");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVas).HasColumnName("cod_hm_vas");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.DoAa).HasColumnName("Do_aa");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabTas).HasColumnName("mab_tas");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.RefF)
                    .HasMaxLength(50)
                    .HasColumnName("ref_f");

                entity.Property(e => e.RefHaz)
                    .HasMaxLength(50)
                    .HasColumnName("ref_haz");

                entity.Property(e => e.RefTas)
                    .HasMaxLength(50)
                    .HasColumnName("ref_tas");

                entity.Property(e => e.RefV)
                    .HasMaxLength(50)
                    .HasColumnName("ref_v");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Takh2).HasColumnName("takh2");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(8)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.Property(e => e.UpdateDate).HasMaxLength(17);

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<Fkhad>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("fkhad");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.MabVarizi).HasColumnName("MAB_VARIZI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Fkhads)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_fkhad_SalMaly");
            });

            modelBuilder.Entity<Fto0>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("fto0");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_fto0")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Fto0s)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_fto0_SalMaly");
            });

            modelBuilder.Entity<Fto2>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Cod, e.Rad, e.NoeFto });

                entity.ToTable("fto2");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.NoeFto)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_FTO");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodC).HasColumnName("COD_C");

                entity.Property(e => e.Dar).HasColumnName("DAR");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.NameC)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_C");

                entity.Property(e => e.TedC).HasColumnName("TED_C");

                entity.Property(e => e.Zarib)
                    .HasMaxLength(10)
                    .HasColumnName("ZARIB");
            });

            modelBuilder.Entity<Fto3>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Cod, e.Rad, e.NoeFto });

                entity.ToTable("fto3");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.NoeFto)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_FTO");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodC).HasColumnName("COD_C");

                entity.Property(e => e.Dar).HasColumnName("DAR");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.NameC)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_C");

                entity.Property(e => e.TedC).HasColumnName("TED_C");

                entity.Property(e => e.Zarib)
                    .HasMaxLength(10)
                    .HasColumnName("ZARIB");
            });

            modelBuilder.Entity<Ftol>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.NoeFto, e.Cod, e.Rad });

                entity.ToTable("ftol");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.NoeFto)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_FTO");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodC).HasColumnName("COD_C");

                entity.Property(e => e.Dar).HasColumnName("DAR");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.NameC)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_C");

                entity.Property(e => e.TedC).HasColumnName("TED_C");

                entity.Property(e => e.Zarib)
                    .HasMaxLength(10)
                    .HasColumnName("ZARIB");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Ftols)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_ftol_SalMaly");
            });

            modelBuilder.Entity<Ftum>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("FTA");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodAnb1).HasColumnName("cod_anb1");

                entity.Property(e => e.CodAnb2).HasColumnName("cod_anb2");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Shg1).HasColumnName("shg1");

                entity.Property(e => e.Shg2).HasColumnName("shg2");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarTo)
                    .HasMaxLength(10)
                    .HasColumnName("tar_to");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Fta)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_FTA_SalMaly");
            });

            modelBuilder.Entity<Ge>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod, e.Rad });

                entity.ToTable("GES");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.MabDir).HasColumnName("MAB_DIR");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarV)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(50)
                    .HasColumnName("VAZ");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Ges)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_GES_SalMaly");
            });

            modelBuilder.Entity<Ge0>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("GE0");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.AdrWorkV)
                    .HasMaxLength(50)
                    .HasColumnName("Adr_work_v");

                entity.Property(e => e.AdrWorkZ)
                    .HasMaxLength(50)
                    .HasColumnName("Adr_work_z");

                entity.Property(e => e.AdresV)
                    .HasMaxLength(100)
                    .HasColumnName("ADRES_v");

                entity.Property(e => e.AdresZ)
                    .HasMaxLength(100)
                    .HasColumnName("ADRES_z");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHogoghV)
                    .HasMaxLength(20)
                    .HasColumnName("Cod_hogogh_v");

                entity.Property(e => e.CodHogoghZ)
                    .HasMaxLength(20)
                    .HasColumnName("Cod_hogogh_z");

                entity.Property(e => e.CodMeliV)
                    .HasMaxLength(15)
                    .HasColumnName("Cod_Meli_v");

                entity.Property(e => e.CodMeliZ)
                    .HasMaxLength(15)
                    .HasColumnName("Cod_Meli_z");

                entity.Property(e => e.CodMoz).HasColumnName("COD_MOZ");

                entity.Property(e => e.CodParvandehV)
                    .HasMaxLength(20)
                    .HasColumnName("cod_parvandeh_v");

                entity.Property(e => e.CodParvandehZ)
                    .HasMaxLength(20)
                    .HasColumnName("cod_parvandeh_z");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.Edg).HasColumnName("EDG");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.MabP).HasColumnName("MAB_P");

                entity.Property(e => e.Moarf1).HasMaxLength(50);

                entity.Property(e => e.Moarf1Adr)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf1_adr");

                entity.Property(e => e.Moarf1Mobil)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf1_mobil");

                entity.Property(e => e.Moarf1Tel)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf1_tel");

                entity.Property(e => e.Moarf2).HasMaxLength(50);

                entity.Property(e => e.Moarf2Adr)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf2_adr");

                entity.Property(e => e.Moarf2Mobil)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf2_mobil");

                entity.Property(e => e.Moarf2Tel)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf2_tel");

                entity.Property(e => e.Moarf3).HasMaxLength(100);

                entity.Property(e => e.Moarf3Adr)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf3_adr");

                entity.Property(e => e.Moarf3Mobil)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf3_mobil");

                entity.Property(e => e.Moarf3Tel)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf3_tel");

                entity.Property(e => e.Moarf4).HasMaxLength(100);

                entity.Property(e => e.Moarf4Adr)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf4_adr");

                entity.Property(e => e.Moarf4Mobil)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf4_mobil");

                entity.Property(e => e.Moarf4Tel)
                    .HasMaxLength(50)
                    .HasColumnName("Moarf4_tel");

                entity.Property(e => e.MobilV)
                    .HasMaxLength(100)
                    .HasColumnName("MOBIL_v");

                entity.Property(e => e.MobilZ)
                    .HasMaxLength(100)
                    .HasColumnName("MOBIL_z");

                entity.Property(e => e.NameV)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_v");

                entity.Property(e => e.NameZ)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_z");

                entity.Property(e => e.NamefatherV)
                    .HasMaxLength(50)
                    .HasColumnName("NAMEFATHER_v");

                entity.Property(e => e.NamefatherZ)
                    .HasMaxLength(50)
                    .HasColumnName("NAMEFATHER_z");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Paygiri)
                    .HasMaxLength(500)
                    .HasColumnName("paygiri");

                entity.Property(e => e.SadereV)
                    .HasMaxLength(50)
                    .HasColumnName("SADERE_v");

                entity.Property(e => e.SadereZ)
                    .HasMaxLength(50)
                    .HasColumnName("SADERE_z");

                entity.Property(e => e.ShoChek).HasMaxLength(50);

                entity.Property(e => e.ShoshV)
                    .HasMaxLength(50)
                    .HasColumnName("SHOSH_v");

                entity.Property(e => e.ShoshZ)
                    .HasMaxLength(50)
                    .HasColumnName("SHOSH_z");

                entity.Property(e => e.TarP)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_P");

                entity.Property(e => e.TarT)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_T");

                entity.Property(e => e.Ted).HasColumnName("TED");

                entity.Property(e => e.TelV)
                    .HasMaxLength(100)
                    .HasColumnName("TEL_v");

                entity.Property(e => e.TelWorkV)
                    .HasMaxLength(50)
                    .HasColumnName("TEL_WORK_v");

                entity.Property(e => e.TelWorkZ)
                    .HasMaxLength(50)
                    .HasColumnName("TEL_WORK_z");

                entity.Property(e => e.TelZ)
                    .HasMaxLength(100)
                    .HasColumnName("TEL_z");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Ge0s)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_GE0_SalMaly");
            });

            modelBuilder.Entity<Ge2>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Cod, e.Rad });

                entity.ToTable("GE2");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.MabDir).HasColumnName("MAB_DIR");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarV)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<He>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("HES");

                entity.HasIndex(e => new { e.ShsId, e.Shom }, "IX_HES")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Cart)
                    .HasMaxLength(40)
                    .HasColumnName("cart");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.Moj).HasColumnName("MOJ");

                entity.Property(e => e.MojAv).HasColumnName("MOJ_AV");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.NameBa)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_BA");

                entity.Property(e => e.Noe)
                    .HasMaxLength(30)
                    .HasColumnName("NOE");

                entity.Property(e => e.Sheba)
                    .HasMaxLength(30)
                    .HasColumnName("sheba");

                entity.Property(e => e.ShoBa)
                    .HasMaxLength(50)
                    .HasColumnName("SHO_BA");

                entity.Property(e => e.Shom)
                    .HasMaxLength(50)
                    .HasColumnName("SHOM");

                entity.Property(e => e.Shomsha)
                    .HasColumnType("ntext")
                    .HasColumnName("SHOMSHA");

                entity.Property(e => e.Tarf)
                    .HasMaxLength(10)
                    .HasColumnName("TARF");

                entity.Property(e => e.Tarhch).HasColumnName("TARHCH");

                entity.Property(e => e.TmpMoj).HasColumnName("TMP_MOJ");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Hes)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_HES_SalMaly");
            });

            modelBuilder.Entity<Ho0>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("HO0");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CodSap).HasColumnName("COD_SAP");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarP)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_P");

                entity.Property(e => e.Ted).HasColumnName("TED");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Ho0s)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_HO0_SalMaly");
            });

            modelBuilder.Entity<Ho2>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Cod, e.Rad });

                entity.ToTable("HO2");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.Jam).HasColumnName("JAM");

                entity.Property(e => e.JamD).HasColumnName("JAM_D");

                entity.Property(e => e.JamK).HasColumnName("JAM_K");

                entity.Property(e => e.JamMan).HasColumnName("JAM_MAN");

                entity.Property(e => e.JamNa).HasColumnName("JAM_NA");

                entity.Property(e => e.Kround).HasColumnName("KROUND");

                entity.Property(e => e.Lman).HasColumnName("LMAN");

                entity.Property(e => e.M01a).HasColumnName("M_01A");

                entity.Property(e => e.M01k).HasColumnName("M_01K");

                entity.Property(e => e.M02a).HasColumnName("M_02A");

                entity.Property(e => e.M02k).HasColumnName("M_02K");

                entity.Property(e => e.M03a).HasColumnName("M_03A");

                entity.Property(e => e.M04a).HasColumnName("M_04A");

                entity.Property(e => e.M05a).HasColumnName("M_05A");

                entity.Property(e => e.M06a).HasColumnName("M_06A");

                entity.Property(e => e.M07a).HasColumnName("M_07A");

                entity.Property(e => e.MAel).HasColumnName("M_AEL");

                entity.Property(e => e.MBD).HasColumnName("M_B_D");

                entity.Property(e => e.MBDK).HasColumnName("M_B_D_K");

                entity.Property(e => e.MBO).HasColumnName("M_B_O");

                entity.Property(e => e.MBah).HasColumnName("M_BAH");

                entity.Property(e => e.MD).HasColumnName("M_D");

                entity.Property(e => e.MDTozih)
                    .HasMaxLength(254)
                    .HasColumnName("M_D_TOZIH");

                entity.Property(e => e.MEza).HasColumnName("M_EZA");

                entity.Property(e => e.MFog).HasColumnName("M_FOG");

                entity.Property(e => e.MJaz).HasColumnName("M_JAZ");

                entity.Property(e => e.MK).HasColumnName("M_K");

                entity.Property(e => e.MKTozih)
                    .HasMaxLength(254)
                    .HasColumnName("M_K_TOZIH");

                entity.Property(e => e.MKha).HasColumnName("M_KHA");

                entity.Property(e => e.MM).HasColumnName("M_M");

                entity.Property(e => e.MMah).HasColumnName("M_MAH");

                entity.Property(e => e.MMas).HasColumnName("M_MAS");

                entity.Property(e => e.MMsk).HasColumnName("M_MSK");

                entity.Property(e => e.MRoz).HasColumnName("M_ROZ");

                entity.Property(e => e.MSak).HasColumnName("M_SAK");

                entity.Property(e => e.MTat).HasColumnName("M_TAT");

                entity.Property(e => e.NEza).HasColumnName("N_EZA");

                entity.Property(e => e.NRoz).HasColumnName("N_ROZ");

                entity.Property(e => e.NTat).HasColumnName("N_TAT");

                entity.Property(e => e.TakPrn)
                    .HasMaxLength(10)
                    .HasColumnName("TAK_PRN");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");
            });

            modelBuilder.Entity<Hog>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod, e.Rad });

                entity.ToTable("HOG");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.Jam).HasColumnName("JAM");

                entity.Property(e => e.JamD).HasColumnName("JAM_D");

                entity.Property(e => e.JamK).HasColumnName("JAM_K");

                entity.Property(e => e.JamMan).HasColumnName("JAM_MAN");

                entity.Property(e => e.JamNa).HasColumnName("JAM_NA");

                entity.Property(e => e.Kround).HasColumnName("KROUND");

                entity.Property(e => e.Lman).HasColumnName("LMAN");

                entity.Property(e => e.M01a).HasColumnName("M_01A");

                entity.Property(e => e.M01k).HasColumnName("M_01K");

                entity.Property(e => e.M02a).HasColumnName("M_02A");

                entity.Property(e => e.M02k).HasColumnName("M_02K");

                entity.Property(e => e.M03a).HasColumnName("M_03A");

                entity.Property(e => e.M04a).HasColumnName("M_04A");

                entity.Property(e => e.M05a).HasColumnName("M_05A");

                entity.Property(e => e.M06a).HasColumnName("M_06A");

                entity.Property(e => e.M07a).HasColumnName("M_07A");

                entity.Property(e => e.MAel).HasColumnName("M_AEL");

                entity.Property(e => e.MBD).HasColumnName("M_B_D");

                entity.Property(e => e.MBDK).HasColumnName("M_B_D_K");

                entity.Property(e => e.MBO).HasColumnName("M_B_O");

                entity.Property(e => e.MBah).HasColumnName("M_BAH");

                entity.Property(e => e.MD).HasColumnName("M_D");

                entity.Property(e => e.MDTozih)
                    .HasMaxLength(254)
                    .HasColumnName("M_D_TOZIH");

                entity.Property(e => e.MEza).HasColumnName("M_EZA");

                entity.Property(e => e.MFog).HasColumnName("M_FOG");

                entity.Property(e => e.MJaz).HasColumnName("M_JAZ");

                entity.Property(e => e.MK).HasColumnName("M_K");

                entity.Property(e => e.MKTozih)
                    .HasMaxLength(254)
                    .HasColumnName("M_K_TOZIH");

                entity.Property(e => e.MKha).HasColumnName("M_KHA");

                entity.Property(e => e.MM).HasColumnName("M_M");

                entity.Property(e => e.MMah).HasColumnName("M_MAH");

                entity.Property(e => e.MMas).HasColumnName("M_MAS");

                entity.Property(e => e.MMsk).HasColumnName("M_MSK");

                entity.Property(e => e.MRoz).HasColumnName("M_ROZ");

                entity.Property(e => e.MSak).HasColumnName("M_SAK");

                entity.Property(e => e.MTat).HasColumnName("M_TAT");

                entity.Property(e => e.NEza).HasColumnName("N_EZA");

                entity.Property(e => e.NRoz).HasColumnName("N_ROZ");

                entity.Property(e => e.NTat).HasColumnName("N_TAT");

                entity.Property(e => e.TakPrn)
                    .HasMaxLength(10)
                    .HasColumnName("TAK_PRN");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Hogs)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_HOG_SalMaly");
            });

            modelBuilder.Entity<Kark>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("KARK");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_KARK")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Adr)
                    .HasMaxLength(100)
                    .HasColumnName("ADR");

                entity.Property(e => e.Bimh).HasColumnName("BIMH");

                entity.Property(e => e.CodFor).HasColumnName("COD_FOR");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.Fal).HasColumnName("FAL");

                entity.Property(e => e.Madr)
                    .HasMaxLength(50)
                    .HasColumnName("MADR");

                entity.Property(e => e.MahK)
                    .HasMaxLength(50)
                    .HasColumnName("MAH_K");

                entity.Property(e => e.Naf)
                    .HasMaxLength(50)
                    .HasColumnName("NAF");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.NameFor)
                    .HasMaxLength(20)
                    .HasColumnName("NAME_FOR");

                entity.Property(e => e.NameKha)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_KHA");

                entity.Property(e => e.Shob)
                    .HasMaxLength(20)
                    .HasColumnName("SHOB");

                entity.Property(e => e.Shod)
                    .HasMaxLength(20)
                    .HasColumnName("SHOD");

                entity.Property(e => e.Shoh)
                    .HasMaxLength(20)
                    .HasColumnName("SHOH");

                entity.Property(e => e.Shok)
                    .HasMaxLength(20)
                    .HasColumnName("SHOK");

                entity.Property(e => e.Shop)
                    .HasMaxLength(20)
                    .HasColumnName("SHOP");

                entity.Property(e => e.Shos)
                    .HasMaxLength(20)
                    .HasColumnName("SHOS");

                entity.Property(e => e.Tel)
                    .HasMaxLength(30)
                    .HasColumnName("TEL");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.VazKh).HasColumnName("VAZ_KH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Karks)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_KARK_SalMaly");
            });

            modelBuilder.Entity<Karkfor>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("KARKFOR");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_KARKFOR")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.JamD)
                    .HasMaxLength(100)
                    .HasColumnName("JAM_D");

                entity.Property(e => e.JamK)
                    .HasMaxLength(100)
                    .HasColumnName("JAM_K");

                entity.Property(e => e.M01a)
                    .HasMaxLength(100)
                    .HasColumnName("M_01A");

                entity.Property(e => e.M01k)
                    .HasMaxLength(100)
                    .HasColumnName("M_01K");

                entity.Property(e => e.M02a)
                    .HasMaxLength(100)
                    .HasColumnName("M_02A");

                entity.Property(e => e.M02k)
                    .HasMaxLength(100)
                    .HasColumnName("M_02K");

                entity.Property(e => e.M03a)
                    .HasMaxLength(100)
                    .HasColumnName("M_03A");

                entity.Property(e => e.M04a)
                    .HasMaxLength(100)
                    .HasColumnName("M_04A");

                entity.Property(e => e.M05a)
                    .HasMaxLength(100)
                    .HasColumnName("M_05A");

                entity.Property(e => e.M06a)
                    .HasMaxLength(100)
                    .HasColumnName("M_06A");

                entity.Property(e => e.M07a)
                    .HasMaxLength(100)
                    .HasColumnName("M_07A");

                entity.Property(e => e.MAel)
                    .HasMaxLength(100)
                    .HasColumnName("M_AEL");

                entity.Property(e => e.MBD)
                    .HasMaxLength(100)
                    .HasColumnName("M_B_D");

                entity.Property(e => e.MBDK)
                    .HasMaxLength(100)
                    .HasColumnName("M_B_D_K");

                entity.Property(e => e.MBO)
                    .HasMaxLength(100)
                    .HasColumnName("M_B_O");

                entity.Property(e => e.MBah)
                    .HasMaxLength(100)
                    .HasColumnName("M_BAH");

                entity.Property(e => e.MD)
                    .HasMaxLength(100)
                    .HasColumnName("M_D");

                entity.Property(e => e.MDTozih)
                    .HasMaxLength(254)
                    .HasColumnName("M_D_TOZIH");

                entity.Property(e => e.MEza)
                    .HasMaxLength(100)
                    .HasColumnName("M_EZA");

                entity.Property(e => e.MFog)
                    .HasMaxLength(100)
                    .HasColumnName("M_FOG");

                entity.Property(e => e.MJaz)
                    .HasMaxLength(100)
                    .HasColumnName("M_JAZ");

                entity.Property(e => e.MK)
                    .HasMaxLength(100)
                    .HasColumnName("M_K");

                entity.Property(e => e.MKTozih)
                    .HasMaxLength(254)
                    .HasColumnName("M_K_TOZIH");

                entity.Property(e => e.MKha)
                    .HasMaxLength(100)
                    .HasColumnName("M_KHA");

                entity.Property(e => e.MM)
                    .HasMaxLength(100)
                    .HasColumnName("M_M");

                entity.Property(e => e.MMah)
                    .HasMaxLength(100)
                    .HasColumnName("M_MAH");

                entity.Property(e => e.MMas)
                    .HasMaxLength(100)
                    .HasColumnName("M_MAS");

                entity.Property(e => e.MMsk)
                    .HasMaxLength(100)
                    .HasColumnName("M_MSK");

                entity.Property(e => e.MRoz)
                    .HasMaxLength(100)
                    .HasColumnName("M_ROZ");

                entity.Property(e => e.MSak)
                    .HasMaxLength(100)
                    .HasColumnName("M_SAK");

                entity.Property(e => e.MTat)
                    .HasMaxLength(100)
                    .HasColumnName("M_TAT");

                entity.Property(e => e.NEza)
                    .HasMaxLength(100)
                    .HasColumnName("N_EZA");

                entity.Property(e => e.NRoz)
                    .HasMaxLength(100)
                    .HasColumnName("N_ROZ");

                entity.Property(e => e.NTat)
                    .HasMaxLength(100)
                    .HasColumnName("N_TAT");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Karkfors)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_KARKFOR_SalMaly");
            });

            modelBuilder.Entity<Kart>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Tar, e.CodHc, e.CodHm, e.Vaz, e.Sat1 });

                entity.ToTable("kart");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");

                entity.Property(e => e.Sat1)
                    .HasMaxLength(5)
                    .HasColumnName("SAT1");

                entity.Property(e => e.Sat2)
                    .HasMaxLength(5)
                    .HasColumnName("SAT2");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(50)
                    .HasColumnName("tozih");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Karts)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_kart_SalMaly");
            });

            modelBuilder.Entity<Kformula>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.A1 });

                entity.ToTable("kformula");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.A1).HasMaxLength(20);

                entity.Property(e => e.A10).HasMaxLength(20);

                entity.Property(e => e.A11).HasMaxLength(20);

                entity.Property(e => e.A12).HasMaxLength(20);

                entity.Property(e => e.A13).HasMaxLength(20);

                entity.Property(e => e.A14).HasMaxLength(20);

                entity.Property(e => e.A15).HasMaxLength(20);

                entity.Property(e => e.A16).HasMaxLength(20);

                entity.Property(e => e.A17).HasMaxLength(20);

                entity.Property(e => e.A18).HasMaxLength(20);

                entity.Property(e => e.A19).HasMaxLength(20);

                entity.Property(e => e.A2).HasMaxLength(20);

                entity.Property(e => e.A20).HasMaxLength(20);

                entity.Property(e => e.A21).HasMaxLength(20);

                entity.Property(e => e.A22).HasMaxLength(20);

                entity.Property(e => e.A23).HasMaxLength(20);

                entity.Property(e => e.A24).HasMaxLength(20);

                entity.Property(e => e.A25).HasMaxLength(20);

                entity.Property(e => e.A26).HasMaxLength(20);

                entity.Property(e => e.A27).HasMaxLength(20);

                entity.Property(e => e.A28).HasMaxLength(20);

                entity.Property(e => e.A29).HasMaxLength(20);

                entity.Property(e => e.A3).HasMaxLength(20);

                entity.Property(e => e.A30).HasMaxLength(20);

                entity.Property(e => e.A31).HasMaxLength(20);

                entity.Property(e => e.A32).HasMaxLength(20);

                entity.Property(e => e.A33).HasMaxLength(20);

                entity.Property(e => e.A34).HasMaxLength(20);

                entity.Property(e => e.A35).HasMaxLength(20);

                entity.Property(e => e.A36).HasMaxLength(20);

                entity.Property(e => e.A37).HasMaxLength(20);

                entity.Property(e => e.A38).HasMaxLength(20);

                entity.Property(e => e.A39).HasMaxLength(20);

                entity.Property(e => e.A4).HasMaxLength(20);

                entity.Property(e => e.A40).HasMaxLength(20);

                entity.Property(e => e.A41).HasMaxLength(20);

                entity.Property(e => e.A42).HasMaxLength(20);

                entity.Property(e => e.A43).HasMaxLength(20);

                entity.Property(e => e.A44).HasMaxLength(20);

                entity.Property(e => e.A45).HasMaxLength(20);

                entity.Property(e => e.A46).HasMaxLength(20);

                entity.Property(e => e.A47).HasMaxLength(20);

                entity.Property(e => e.A48).HasMaxLength(20);

                entity.Property(e => e.A49).HasMaxLength(20);

                entity.Property(e => e.A5).HasMaxLength(20);

                entity.Property(e => e.A50).HasMaxLength(20);

                entity.Property(e => e.A6).HasMaxLength(20);

                entity.Property(e => e.A7).HasMaxLength(20);

                entity.Property(e => e.A8).HasMaxLength(20);

                entity.Property(e => e.A9).HasMaxLength(20);
            });

            modelBuilder.Entity<Khad>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("khad");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_khad")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.MabM).HasColumnName("MAB_M");

                entity.Property(e => e.MabS).HasColumnName("MAB_S");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Khads)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_khad_SalMaly");
            });

            modelBuilder.Entity<Mfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mfo");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcTas).HasColumnName("cod_hc_tas");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVas).HasColumnName("cod_hc_vas");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmN).HasColumnName("COD_HM_N");

                entity.Property(e => e.CodHmTas).HasColumnName("cod_hm_tas");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVas).HasColumnName("cod_hm_vas");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.DoAa).HasColumnName("Do_aa");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabTas).HasColumnName("mab_tas");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.RefF)
                    .HasMaxLength(50)
                    .HasColumnName("ref_f");

                entity.Property(e => e.RefHaz)
                    .HasMaxLength(50)
                    .HasColumnName("ref_haz");

                entity.Property(e => e.RefTas)
                    .HasMaxLength(50)
                    .HasColumnName("ref_tas");

                entity.Property(e => e.RefV)
                    .HasMaxLength(50)
                    .HasColumnName("ref_v");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Takh2).HasColumnName("takh2");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(8)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.Property(e => e.UpdateDate).HasMaxLength(17);

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<Mkh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mkh");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcTas).HasColumnName("cod_hc_tas");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVas).HasColumnName("cod_hc_vas");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmN).HasColumnName("COD_HM_N");

                entity.Property(e => e.CodHmTas).HasColumnName("cod_hm_tas");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVas).HasColumnName("cod_hm_vas");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.DoAa).HasColumnName("Do_aa");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabTas).HasColumnName("mab_tas");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.RefF)
                    .HasMaxLength(50)
                    .HasColumnName("ref_f");

                entity.Property(e => e.RefHaz)
                    .HasMaxLength(50)
                    .HasColumnName("ref_haz");

                entity.Property(e => e.RefTas)
                    .HasMaxLength(50)
                    .HasColumnName("ref_tas");

                entity.Property(e => e.RefV)
                    .HasMaxLength(50)
                    .HasColumnName("ref_v");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Takh2).HasColumnName("takh2");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(8)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.Property(e => e.UpdateDate).HasMaxLength(17);

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<Mo>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("MOS");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_MOS")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Accountant).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.AdrWork)
                    .HasMaxLength(50)
                    .HasColumnName("Adr_work");

                entity.Property(e => e.Adres)
                    .HasMaxLength(100)
                    .HasColumnName("ADRES");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHogogh)
                    .HasMaxLength(20)
                    .HasColumnName("Cod_hogogh");

                entity.Property(e => e.CodMeli)
                    .HasMaxLength(15)
                    .HasColumnName("Cod_Meli");

                entity.Property(e => e.CodOld).HasColumnName("COD_OLD");

                entity.Property(e => e.CodParvandeh)
                    .HasMaxLength(20)
                    .HasColumnName("cod_parvandeh");

                entity.Property(e => e.CodeEqtesadi).HasMaxLength(50);

                entity.Property(e => e.CrmId).HasColumnName("crm_id");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .HasColumnName("FAX");

                entity.Property(e => e.Hesab).HasColumnName("HESAB");

                entity.Property(e => e.Joz)
                    .HasMaxLength(254)
                    .HasColumnName("JOZ");

                entity.Property(e => e.Mobil)
                    .HasMaxLength(100)
                    .HasColumnName("MOBIL");

                entity.Property(e => e.Modir)
                    .HasMaxLength(50)
                    .HasColumnName("modir");

                entity.Property(e => e.Mp3)
                    .HasMaxLength(254)
                    .HasColumnName("MP3");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Namefather)
                    .HasMaxLength(50)
                    .HasColumnName("NAMEFATHER");

                entity.Property(e => e.NoeMos)
                    .HasMaxLength(20)
                    .HasColumnName("NOE_MOS");

                entity.Property(e => e.Phesab).HasColumnName("PHESAB");

                entity.Property(e => e.Pic)
                    .HasMaxLength(254)
                    .HasColumnName("PIC");

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.Representative).HasMaxLength(50);

                entity.Property(e => e.RozS).HasColumnName("Roz_S");

                entity.Property(e => e.Sadere)
                    .HasMaxLength(50)
                    .HasColumnName("SADERE");

                entity.Property(e => e.Shoh)
                    .HasMaxLength(100)
                    .HasColumnName("SHOH");

                entity.Property(e => e.Shosh)
                    .HasMaxLength(50)
                    .HasColumnName("SHOSH");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(500)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.TarT)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_T");

                entity.Property(e => e.Tel)
                    .HasMaxLength(100)
                    .HasColumnName("TEL");

                entity.Property(e => e.TelWork)
                    .HasMaxLength(50)
                    .HasColumnName("TEL_WORK");

                entity.Property(e => e.TmpHesab).HasColumnName("TMP_HESAB");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Mos)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_MOS_SalMaly");
            });

            modelBuilder.Entity<Moe>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.CodHc, e.Cod });

                entity.ToTable("MOE");

                entity.HasIndex(e => new { e.ShsId, e.CodHc, e.Name }, "IX_MOE")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShsId, e.CodHc, e.Cod }, "IX_MOE_1");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Etebar).HasColumnName("ETEBAR");

                entity.Property(e => e.IdTbSysCurrencies2).HasColumnName("id_tbSysCurrencies2");

                entity.Property(e => e.IdTbSysCurrencies3).HasColumnName("id_tbSysCurrencies3");

                entity.Property(e => e.Masdod).HasColumnName("MASDOD");

                entity.Property(e => e.Moj).HasColumnName("MOJ");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(500)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.TbCod).HasColumnName("TB_COD");

                entity.Property(e => e.TbName)
                    .HasMaxLength(10)
                    .HasColumnName("TB_NAME");

                entity.Property(e => e.TmpMoj).HasColumnName("TMP_MOJ");

                entity.Property(e => e.TmpMojbs).HasColumnName("TMP_MOJBS");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Moes)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_MOE_SalMaly");
            });

            modelBuilder.Entity<Moz>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("MOZ");

                entity.HasIndex(e => new { e.ShsId, e.Moz1 }, "IX_MOZ")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Moz1)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Mozs)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_MOZ_SalMaly");
            });

            modelBuilder.Entity<Moz2>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("MOZ2");

                entity.HasIndex(e => new { e.ShsId, e.Moz }, "IX_MOZ2")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Moz2s)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_MOZ2_SalMaly");
            });

            modelBuilder.Entity<Pfa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("pfa");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcTas).HasColumnName("cod_hc_tas");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVas).HasColumnName("cod_hc_vas");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmN).HasColumnName("COD_HM_N");

                entity.Property(e => e.CodHmTas).HasColumnName("cod_hm_tas");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVas).HasColumnName("cod_hm_vas");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.CrateDate).HasMaxLength(17);

                entity.Property(e => e.DoAa).HasColumnName("Do_aa");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabTas).HasColumnName("mab_tas");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.RefF)
                    .HasMaxLength(50)
                    .HasColumnName("ref_f");

                entity.Property(e => e.RefHaz)
                    .HasMaxLength(50)
                    .HasColumnName("ref_haz");

                entity.Property(e => e.RefTas)
                    .HasMaxLength(50)
                    .HasColumnName("ref_tas");

                entity.Property(e => e.RefV)
                    .HasMaxLength(50)
                    .HasColumnName("ref_v");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.Takh2).HasColumnName("takh2");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(8)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Tozih2)
                    .HasMaxLength(50)
                    .HasColumnName("tozih2");

                entity.Property(e => e.UpdateDate).HasMaxLength(17);

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("PROJECTS");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_PROJECTS")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Mab).HasColumnName("mab");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("NAME");

                entity.Property(e => e.Takmil).HasColumnName("TAKMIL");

                entity.Property(e => e.TarP)
                    .HasMaxLength(10)
                    .HasColumnName("tar_p");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarSS)
                    .HasMaxLength(10)
                    .HasColumnName("tar_s_s");

                entity.Property(e => e.TarT)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_T");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_PROJECTS_SalMaly");
            });

            modelBuilder.Entity<Ra>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Rad });

                entity.ToTable("RAS");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");
            });

            modelBuilder.Entity<RasD>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Rad });

                entity.ToTable("RAS_D");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");
            });

            modelBuilder.Entity<Sa0>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("SA0");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.EditCount).HasColumnName("editCount");

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.Gat).HasColumnName("GAT");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Payvast).HasColumnName("payvast");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Sa0s)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_SA0_SalMaly");
            });

            modelBuilder.Entity<Sa2>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Cod, e.Rad });

                entity.ToTable("Sa2");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Acronym2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Acronym3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodMos)
                    .HasColumnName("cod_mos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMoz).HasColumnName("COD_MOZ");

                entity.Property(e => e.CodMozJ).HasColumnName("COD_MOZ_J");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Exchange2).HasDefaultValueSql("((1))");

                entity.Property(e => e.Exchange3).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Mab2).HasColumnName("mab2");

                entity.Property(e => e.Mab3).HasColumnName("mab3");

                entity.Property(e => e.Mbd).HasColumnName("MBD");

                entity.Property(e => e.Mbs).HasColumnName("MBS");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Saat)
                    .HasMaxLength(8)
                    .HasColumnName("SAAT");

                entity.Property(e => e.Shog).HasColumnName("SHOG");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Tek)
                    .HasColumnName("TEK")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Vaz).HasColumnName("VAZ");
            });

            modelBuilder.Entity<Sa3>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Cod, e.Rad });

                entity.ToTable("SA3");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Acronym2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Acronym3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodMos)
                    .HasColumnName("cod_mos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMoz).HasColumnName("COD_MOZ");

                entity.Property(e => e.CodMozJ).HasColumnName("COD_MOZ_J");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Exchange2).HasDefaultValueSql("((1))");

                entity.Property(e => e.Exchange3).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Mab2).HasColumnName("mab2");

                entity.Property(e => e.Mab3).HasColumnName("mab3");

                entity.Property(e => e.Mbd).HasColumnName("MBD");

                entity.Property(e => e.Mbs).HasColumnName("MBS");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Saat)
                    .HasMaxLength(8)
                    .HasColumnName("SAAT");

                entity.Property(e => e.Shog).HasColumnName("SHOG");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Tek).HasColumnName("TEK");

                entity.Property(e => e.Vaz).HasColumnName("VAZ");
            });

            modelBuilder.Entity<SalMaly>(entity =>
            {
                entity.HasKey(e => e.ShsId);

                entity.ToTable("SalMaly");

                entity.HasIndex(e => new { e.Root, e.Sal }, "IX_SalMaly")
                    .IsUnique();

                entity.Property(e => e.ShsId)
                    .ValueGeneratedNever()
                    .HasColumnName("SHS_ID");

                entity.Property(e => e.Root).HasColumnName("root");

                entity.Property(e => e.Sal).HasColumnName("sal");

                entity.HasOne(d => d.RootNavigation)
                    .WithMany(p => p.SalMalies)
                    .HasForeignKey(d => d.Root)
                    .HasConstraintName("FK_SalMaly_SHerkat");
            });

            modelBuilder.Entity<San>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod, e.Rad });

                entity.ToTable("SAN");

                entity.HasIndex(e => new { e.ShsId, e.CodHc, e.CodHm, e.Tar }, "IX_SAN");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Acronym2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Acronym3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodMos)
                    .HasColumnName("cod_mos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodMoz).HasColumnName("COD_MOZ");

                entity.Property(e => e.CodMozJ).HasColumnName("COD_MOZ_J");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Exchange2).HasDefaultValueSql("((1))");

                entity.Property(e => e.Exchange3).HasDefaultValueSql("((1))");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Mab2).HasColumnName("mab2");

                entity.Property(e => e.Mab3).HasColumnName("mab3");

                entity.Property(e => e.Mbd).HasColumnName("MBD");

                entity.Property(e => e.Mbs).HasColumnName("MBS");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Saat)
                    .HasMaxLength(8)
                    .HasColumnName("SAAT");

                entity.Property(e => e.Shog).HasColumnName("SHOG");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Tek).HasColumnName("TEK");

                entity.Property(e => e.Vaz).HasColumnName("VAZ");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Sans)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_SAN_SalMaly");
            });

            modelBuilder.Entity<Sherkat>(entity =>
            {
                entity.ToTable("SHerkat");

                entity.HasIndex(e => e.Name, "IX_SHerkat")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Shobe>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("shobe");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("NAME");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Shobes)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_shobe_SalMaly");
            });

            modelBuilder.Entity<SodZian>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Radif });

                entity.ToTable("sod_zian");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Radif).HasColumnName("radif");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.Mab1).HasColumnName("MAB1");

                entity.Property(e => e.Mab2).HasColumnName("MAB2");

                entity.Property(e => e.Mab3).HasColumnName("MAB3");

                entity.Property(e => e.Man).HasColumnName("MAN");

                entity.Property(e => e.NameHc)
                    .HasMaxLength(100)
                    .HasColumnName("NAME_HC");

                entity.Property(e => e.NoeEs)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_ES");
            });

            modelBuilder.Entity<Spy>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("SPY");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Aml)
                    .HasMaxLength(20)
                    .HasColumnName("AML");

                entity.Property(e => e.Ban)
                    .HasMaxLength(50)
                    .HasColumnName("BAN");

                entity.Property(e => e.Comnam)
                    .HasMaxLength(20)
                    .HasColumnName("COMNAM");

                entity.Property(e => e.Onv)
                    .HasMaxLength(30)
                    .HasColumnName("ONV");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Time)
                    .HasMaxLength(8)
                    .HasColumnName("TIME");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(1024)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.User)
                    .HasMaxLength(20)
                    .HasColumnName("USER");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Spies)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_SPY_SalMaly");
            });

            modelBuilder.Entity<Taf>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("TAF");

                entity.HasIndex(e => new { e.ShsId, e.CodR, e.Tafzil }, "IX_TAF")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodR).HasColumnName("COD_R");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(100)
                    .HasColumnName("TAFZIL");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Tafs)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_TAF_SalMaly");
            });

            modelBuilder.Entity<Tafcal>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("tafcal");

                entity.HasIndex(e => new { e.ShsId, e.CodR, e.Tafzil }, "IX_tafcal")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodR).HasColumnName("COD_R");

                entity.Property(e => e.Darvizitor).HasColumnName("DARVIZITOR");

                entity.Property(e => e.FfoNoe)
                    .HasMaxLength(50)
                    .HasColumnName("ffo_noe");

                entity.Property(e => e.FiEn)
                    .HasMaxLength(50)
                    .HasColumnName("fi_EN");

                entity.Property(e => e.FiFa)
                    .HasMaxLength(50)
                    .HasColumnName("fi_FA");

                entity.Property(e => e.GhFo).HasColumnName("gh_fo");

                entity.Property(e => e.GhFoj).HasColumnName("gh_foj");

                entity.Property(e => e.GhFok).HasColumnName("gh_fok");

                entity.Property(e => e.HadTedffo).HasColumnName("HAD_TEDFFO");

                entity.Property(e => e.RozS).HasColumnName("ROZ_S");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(100)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.Takh).HasColumnName("takh");

                entity.Property(e => e.TakhZar).HasColumnName("takh_zar");

                entity.Property(e => e.TbEn)
                    .HasMaxLength(50)
                    .HasColumnName("tb_EN");

                entity.Property(e => e.TbFa)
                    .HasMaxLength(50)
                    .HasColumnName("tb_FA");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Tafcals)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_tafcal_SalMaly");
            });

            modelBuilder.Entity<Tan>(entity =>
            {
                entity.HasKey(e => e.ShsId);

                entity.ToTable("Tan");

                entity.Property(e => e.ShsId)
                    .ValueGeneratedNever()
                    .HasColumnName("SHS_ID");

                entity.Property(e => e.AaCodHc).HasColumnName("AA_COD_HC");

                entity.Property(e => e.AaCodHck).HasColumnName("AA_COD_HCK");

                entity.Property(e => e.AaDar).HasColumnName("AA_DAR");

                entity.Property(e => e.Ada).HasColumnName("ADA");

                entity.Property(e => e.Adr)
                    .HasMaxLength(254)
                    .HasColumnName("ADR");

                entity.Property(e => e.Apa).HasColumnName("APA");

                entity.Property(e => e.Arm)
                    .HasColumnType("image")
                    .HasColumnName("arm");

                entity.Property(e => e.AsSet).HasColumnName("AS_SET");

                entity.Property(e => e.AsTime).HasColumnName("AS_TIME");

                entity.Property(e => e.Ashar).HasColumnName("ASHAR");

                entity.Property(e => e.Asharhog).HasColumnName("ASHARHOG");

                entity.Property(e => e.AutoChp).HasColumnName("AUTO_CHP");

                entity.Property(e => e.Autopath)
                    .HasMaxLength(254)
                    .HasColumnName("AUTOPATH");

                entity.Property(e => e.Autosanoff).HasColumnName("AUTOSANOFF");

                entity.Property(e => e.BarcodSel).HasColumnName("BARCOD_SEL");

                entity.Property(e => e.Bem).HasColumnName("BEM");

                entity.Property(e => e.Bestankarn).HasColumnName("BESTANKARN");

                entity.Property(e => e.Cadr).HasColumnName("CADR");

                entity.Property(e => e.CalendarType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Callerid).HasColumnName("CALLERID");

                entity.Property(e => e.Cam).HasColumnName("CAM");

                entity.Property(e => e.Carm).HasColumnName("CARM");

                entity.Property(e => e.Ccode).HasColumnName("CCODE");

                entity.Property(e => e.Cfontsize).HasColumnName("CFONTSIZE");

                entity.Property(e => e.ChapMor).HasColumnName("CHAP_MOR");

                entity.Property(e => e.Chapfacted).HasColumnName("CHAPFACTED");

                entity.Property(e => e.Chapfacviz).HasColumnName("CHAPFACVIZ");

                entity.Property(e => e.Chapfaczar).HasColumnName("CHAPFACZAR");

                entity.Property(e => e.Chapfont)
                    .HasMaxLength(50)
                    .HasColumnName("CHAPFONT");

                entity.Property(e => e.Chaptedhcm).HasColumnName("CHAPTEDHCM");

                entity.Property(e => e.ChpDay).HasColumnName("CHP_DAY");

                entity.Property(e => e.ChpSet).HasColumnName("CHP_SET");

                entity.Property(e => e.ChpTozF).HasColumnName("CHP_TOZ_F");

                entity.Property(e => e.ChpTozFt).HasColumnName("CHP_TOZ_FT");

                entity.Property(e => e.ChpTozHo).HasColumnName("CHP_TOZ_HO");

                entity.Property(e => e.ChpTozPf).HasColumnName("CHP_TOZ_PF");

                entity.Property(e => e.ChpTozS).HasColumnName("CHP_TOZ_S");

                entity.Property(e => e.ChpadrCol).HasColumnName("CHPADR_COL");

                entity.Property(e => e.Chpkarb).HasColumnName("CHPKARB");

                entity.Property(e => e.ChptozCol).HasColumnName("CHPTOZ_COL");

                entity.Property(e => e.Cmhf).HasColumnName("CMHF");

                entity.Property(e => e.Cmos).HasColumnName("CMOS");

                entity.Property(e => e.CodAsli).HasColumnName("COD_ASLI");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .HasColumnName("CODE");

                entity.Property(e => e.CodeMelli)
                    .HasMaxLength(50)
                    .HasColumnName("Code_Melli");

                entity.Property(e => e.CrmServer)
                    .HasMaxLength(50)
                    .HasColumnName("CRM_Server");

                entity.Property(e => e.CrmServerPass)
                    .HasMaxLength(50)
                    .HasColumnName("CRM_ServerPass");

                entity.Property(e => e.CrmShsId).HasColumnName("crm_shs_id");

                entity.Property(e => e.Ctram).HasColumnName("CTRAM");

                entity.Property(e => e.Dar).HasColumnName("DAR");

                entity.Property(e => e.DbfCb)
                    .HasMaxLength(254)
                    .HasColumnName("DBF_CB");

                entity.Property(e => e.Dbffont).HasColumnName("DBFFONT");

                entity.Property(e => e.Displayfb).HasColumnName("DISPLAYFB");

                entity.Property(e => e.Displayfnt)
                    .HasMaxLength(50)
                    .HasColumnName("DISPLAYFNT");

                entity.Property(e => e.Displayfs).HasColumnName("DISPLAYFS");

                entity.Property(e => e.DoCrm).HasColumnName("DoCRM");

                entity.Property(e => e.DoSms).HasColumnName("DoSMS");

                entity.Property(e => e.Docalgroup).HasColumnName("DOCALGROUP");

                entity.Property(e => e.Dofacnagh).HasColumnName("DOFACNAGH");

                entity.Property(e => e.Dohadfor).HasColumnName("DOHADFOR");

                entity.Property(e => e.Doprojects).HasColumnName("DOPROJECTS");

                entity.Property(e => e.Doserial).HasColumnName("DOSERIAL");

                entity.Property(e => e.Doshobe).HasColumnName("DOSHOBE");

                entity.Property(e => e.Dovizitor).HasColumnName("DOVIZITOR");

                entity.Property(e => e.EditSa2).HasColumnName("EDIT_SA2");

                entity.Property(e => e.Ertfac).HasColumnName("ERTFAC");

                entity.Property(e => e.EsName).HasColumnName("ES_NAME");

                entity.Property(e => e.FacChkKa).HasColumnName("FAC_CHK_KA");

                entity.Property(e => e.FacEmz1)
                    .HasMaxLength(100)
                    .HasColumnName("FAC_EMZ1");

                entity.Property(e => e.FacEmz2)
                    .HasMaxLength(100)
                    .HasColumnName("FAC_EMZ2");

                entity.Property(e => e.FacEmz3)
                    .HasMaxLength(100)
                    .HasColumnName("FAC_EMZ3");

                entity.Property(e => e.FacEmz4)
                    .HasMaxLength(100)
                    .HasColumnName("FAC_EMZ4");

                entity.Property(e => e.FacEmz5)
                    .HasMaxLength(100)
                    .HasColumnName("FAC_EMZ5");

                entity.Property(e => e.FacLabel)
                    .HasMaxLength(20)
                    .HasColumnName("FAC_LABEL");

                entity.Property(e => e.FaccodSa).HasColumnName("FACCOD_SA");

                entity.Property(e => e.Facdbg1).HasColumnName("FACDBG1");

                entity.Property(e => e.Facshoms).HasColumnName("FACSHOMS");

                entity.Property(e => e.FactarS).HasColumnName("FACTAR_S");

                entity.Property(e => e.Factars1).HasColumnName("FACTARS");

                entity.Property(e => e.Fasfishhog).HasColumnName("FASFISHHOG");

                entity.Property(e => e.FfoaLabel)
                    .HasMaxLength(20)
                    .HasColumnName("FFOA_LABEL");

                entity.Property(e => e.Ffotoplkha).HasColumnName("FFOTOPLKHA");

                entity.Property(e => e.Fontsize).HasColumnName("FONTSIZE");

                entity.Property(e => e.For).HasColumnName("FOR");

                entity.Property(e => e.FprnFree).HasColumnName("FPRN_FREE");

                entity.Property(e => e.FrepTar1)
                    .HasMaxLength(8)
                    .HasColumnName("FREP_TAR1");

                entity.Property(e => e.FrepTar2)
                    .HasMaxLength(8)
                    .HasColumnName("FREP_TAR2");

                entity.Property(e => e.Ftasankark).HasColumnName("FTASANKARK");

                entity.Property(e => e.Groupshom).HasColumnName("GROUPSHOM");

                entity.Property(e => e.HPaper).HasColumnName("H_PAPER");

                entity.Property(e => e.Hashieh).HasColumnName("HASHIEH");

                entity.Property(e => e.Hashieh2).HasColumnName("HASHIEH2");

                entity.Property(e => e.Hashieh3).HasColumnName("HASHIEH3");

                entity.Property(e => e.Hashieh4).HasColumnName("HASHIEH4");

                entity.Property(e => e.Hda).HasColumnName("HDA");

                entity.Property(e => e.Hes).HasColumnName("HES");

                entity.Property(e => e.Hfo).HasColumnName("HFO");

                entity.Property(e => e.Hideobjfac).HasColumnName("HIDEOBJFAC");

                entity.Property(e => e.Hkark).HasColumnName("HKARK");

                entity.Property(e => e.Hkh).HasColumnName("HKH");

                entity.Property(e => e.Hko).HasColumnName("HKO");

                entity.Property(e => e.Hta).HasColumnName("HTA");

                entity.Property(e => e.Kark).HasColumnName("KARK");

                entity.Property(e => e.Kha).HasColumnName("KHA");

                entity.Property(e => e.Lockcod).HasColumnName("LOCKCOD");

                entity.Property(e => e.Lockdate)
                    .HasMaxLength(10)
                    .HasColumnName("LOCKDATE");

                entity.Property(e => e.Maliat).HasColumnName("MALIAT");

                entity.Property(e => e.MaxFie).HasColumnName("MAX_FIE");

                entity.Property(e => e.Mdg).HasColumnName("MDG");

                entity.Property(e => e.Mfo).HasColumnName("MFO");

                entity.Property(e => e.MinmaxW).HasColumnName("MINMAX_W");

                entity.Property(e => e.Mka).HasColumnName("MKA");

                entity.Property(e => e.Mkh).HasColumnName("MKH");

                entity.Property(e => e.Mkp).HasColumnName("MKP");

                entity.Property(e => e.Mor1)
                    .HasMaxLength(100)
                    .HasColumnName("MOR1");

                entity.Property(e => e.Mor2)
                    .HasMaxLength(100)
                    .HasColumnName("MOR2");

                entity.Property(e => e.Mor3)
                    .HasMaxLength(100)
                    .HasColumnName("MOR3");

                entity.Property(e => e.Mor4)
                    .HasMaxLength(100)
                    .HasColumnName("MOR4");

                entity.Property(e => e.Mor5)
                    .HasMaxLength(100)
                    .HasColumnName("MOR5");

                entity.Property(e => e.Morf)
                    .HasMaxLength(100)
                    .HasColumnName("MORF");

                entity.Property(e => e.Mos).HasColumnName("MOS");

                entity.Property(e => e.Nameco)
                    .HasMaxLength(100)
                    .HasColumnName("NAMECO");

                entity.Property(e => e.Namezip)
                    .HasMaxLength(50)
                    .HasColumnName("NAMEZIP");

                entity.Property(e => e.Nemahint).HasColumnName("NEMAHINT");

                entity.Property(e => e.NoKhoda).HasColumnName("NO_KHODA");

                entity.Property(e => e.NoLine2).HasColumnName("NO_LINE2");

                entity.Property(e => e.Noautozip).HasColumnName("NOAUTOZIP");

                entity.Property(e => e.Nodelspace).HasColumnName("NODELSPACE");

                entity.Property(e => e.Noechap)
                    .HasMaxLength(10)
                    .HasColumnName("NOECHAP");

                entity.Property(e => e.Noechapfac).HasColumnName("NOECHAPFAC");

                entity.Property(e => e.Noepaper)
                    .HasMaxLength(10)
                    .HasColumnName("NOEPAPER");

                entity.Property(e => e.Noesearch)
                    .HasMaxLength(15)
                    .HasColumnName("NOESEARCH");

                entity.Property(e => e.Noetakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOETAKH");

                entity.Property(e => e.Noezar).HasColumnName("NOEZAR");

                entity.Property(e => e.Noezip)
                    .HasMaxLength(10)
                    .HasColumnName("NOEZIP");

                entity.Property(e => e.Nomoemoj).HasColumnName("NOMOEMOJ");

                entity.Property(e => e.Noshog).HasColumnName("NOSHOG");

                entity.Property(e => e.Nosizecchk).HasColumnName("NOSIZECCHK");

                entity.Property(e => e.Nosotsepar).HasColumnName("NOSOTSEPAR");

                entity.Property(e => e.OpenSa).HasColumnName("OPEN_SA");

                entity.Property(e => e.PeyEtebar).HasColumnName("PEY_ETEBAR");

                entity.Property(e => e.PeyMasdod).HasColumnName("PEY_MASDOD");

                entity.Property(e => e.PeyNoecol).HasColumnName("PEY_NOECOL");

                entity.Property(e => e.Polstring)
                    .HasMaxLength(10)
                    .HasColumnName("POLSTRING");

                entity.Property(e => e.PostalCode).HasMaxLength(20);

                entity.Property(e => e.Radhigh).HasColumnName("RADHIGH");

                entity.Property(e => e.Radsepar).HasColumnName("RADSEPAR");

                entity.Property(e => e.San).HasColumnName("SAN");

                entity.Property(e => e.SanfacAba).HasColumnName("SANFAC_ABA");

                entity.Property(e => e.SanfacBar).HasColumnName("SANFAC_BAR");

                entity.Property(e => e.SanfacCal).HasColumnName("SANFAC_CAL");

                entity.Property(e => e.SanfacShs).HasColumnName("SANFAC_SHS");

                entity.Property(e => e.SanfacTca).HasColumnName("SANFAC_TCA");

                entity.Property(e => e.SanfacTfa).HasColumnName("SANFAC_TFA");

                entity.Property(e => e.Sanfackhad).HasColumnName("SANFACKHAD");

                entity.Property(e => e.ScanPath).HasMaxLength(254);

                entity.Property(e => e.SepFie)
                    .HasMaxLength(1)
                    .HasColumnName("SEP_FIE");

                entity.Property(e => e.ShommojAv).HasColumnName("SHOMMOJ_AV");

                entity.Property(e => e.Showmanfac).HasColumnName("SHOWMANFAC");

                entity.Property(e => e.Showmanzar).HasColumnName("SHOWMANZAR");

                entity.Property(e => e.ShowtarS).HasColumnName("SHOWTAR_S");

                entity.Property(e => e.SodZian).HasColumnName("SOD_ZIAN");

                entity.Property(e => e.Splitabad).HasColumnName("SPLITABAD");

                entity.Property(e => e.Stretch).HasColumnName("STRETCH");

                entity.Property(e => e.TanChap).HasColumnName("TAN_CHAP");

                entity.Property(e => e.Tankha).HasColumnName("TANKHA");

                entity.Property(e => e.TankhaEt).HasColumnName("TANKHA_ET");

                entity.Property(e => e.TarhFac).HasColumnName("TARH_FAC");

                entity.Property(e => e.TarhSa0).HasColumnName("TARH_SA0");

                entity.Property(e => e.Tda).HasColumnName("TDA");

                entity.Property(e => e.TedCP).HasColumnName("TED_C_P");

                entity.Property(e => e.TedHcm).HasColumnName("TED_HCM");

                entity.Property(e => e.Tedcopyfac).HasColumnName("TEDCOPYFAC");

                entity.Property(e => e.TozFac)
                    .HasColumnType("ntext")
                    .HasColumnName("TOZ_FAC");

                entity.Property(e => e.TozFta)
                    .HasColumnType("ntext")
                    .HasColumnName("TOZ_FTA");

                entity.Property(e => e.TozHog)
                    .HasColumnType("ntext")
                    .HasColumnName("TOZ_HOG");

                entity.Property(e => e.TozPfa)
                    .HasColumnType("ntext")
                    .HasColumnName("TOZ_PFA");

                entity.Property(e => e.TozSan)
                    .HasColumnType("ntext")
                    .HasColumnName("TOZ_SAN");

                entity.Property(e => e.TozihCadd).HasColumnName("TOZIH_CADD");

                entity.Property(e => e.Tozihtoagl).HasColumnName("TOZIHTOAGL");

                entity.Property(e => e.Tpa).HasColumnName("TPA");

                entity.Property(e => e.UpdateCriteria)
                    .HasColumnName("Update_Criteria")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vizitor).HasColumnName("VIZITOR");

                entity.Property(e => e.WPaper).HasColumnName("W_PAPER");

                entity.Property(e => e.Wordwrap).HasColumnName("WORDWRAP");

                entity.Property(e => e.Zippath)
                    .HasMaxLength(254)
                    .HasColumnName("ZIPPATH");

                entity.HasOne(d => d.Shs)
                    .WithOne(p => p.Tan)
                    .HasForeignKey<Tan>(d => d.ShsId)
                    .HasConstraintName("FK_Tan_SalMaly");
            });

            modelBuilder.Entity<TarDb>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Mah, e.CodHc });

                entity.ToTable("TAR_DBS");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Mah)
                    .HasMaxLength(20)
                    .HasColumnName("MAH");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHc2).HasColumnName("cod_hc2");

                entity.Property(e => e.Mah2)
                    .HasMaxLength(20)
                    .HasColumnName("mah2");

                entity.Property(e => e.Mbd).HasColumnName("MBD");

                entity.Property(e => e.Mbs).HasColumnName("MBS");

                entity.Property(e => e.NameHc)
                    .HasMaxLength(254)
                    .HasColumnName("NAME_HC");

                entity.Property(e => e.NameHc2)
                    .HasMaxLength(254)
                    .HasColumnName("name_hc2");

                entity.Property(e => e.NoeEsid).HasColumnName("NOE_ESId");

                entity.Property(e => e.NoeEsid2).HasColumnName("NOE_ESId2");
            });

            modelBuilder.Entity<TarzT>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Rad });

                entity.ToTable("tarz_t");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Level).HasColumnName("LEVEL");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Man).HasColumnName("MAN");

                entity.Property(e => e.Mbd).HasColumnName("MBD");

                entity.Property(e => e.Mbs).HasColumnName("MBS");

                entity.Property(e => e.Name)
                    .HasMaxLength(254)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<TbSysCurrency>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Id })
                    .HasName("PK_tbSysCurrencies");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_tbSysCurrencies")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acronym)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.FormatDisplay).HasMaxLength(20);

                entity.Property(e => e.LastUpdate).HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.TbSysCurrencies)
                    .HasForeignKey(d => d.ShsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbSysCurrencies_SalMaly");
            });

            modelBuilder.Entity<TbSysFeildDataDictionary>(entity =>
            {
                entity.ToTable("TbSysFeildDataDictionary");

                entity.HasIndex(e => new { e.IdTbSysTableDataDictionary, e.Name }, "IX_TbSysFeildDataDictionary")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Kind).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdTbSysTableDataDictionaryNavigation)
                    .WithMany(p => p.TbSysFeildDataDictionaries)
                    .HasForeignKey(d => d.IdTbSysTableDataDictionary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSysFeildDataDictionary_TbSysTableDataDictionary");
            });

            modelBuilder.Entity<TbSysForm>(entity =>
            {
                entity.ToTable("TbSysForm");

                entity.HasIndex(e => e.Name, "IX_TbSysForm")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Crc)
                    .HasMaxLength(50)
                    .HasColumnName("CRC");

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TbSysFormFeildDataDictionary>(entity =>
            {
                entity.ToTable("TbSysFormFeildDataDictionary");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FarsiLabel).HasMaxLength(50);

                entity.HasOne(d => d.IdTbSysFeildDataDictionaryNavigation)
                    .WithMany(p => p.TbSysFormFeildDataDictionaries)
                    .HasForeignKey(d => d.IdTbSysFeildDataDictionary)
                    .HasConstraintName("FK_TbSysFormFeildDataDictionary_TbSysTableDataDictionary");

                entity.HasOne(d => d.IdTbSysFormNavigation)
                    .WithMany(p => p.TbSysFormFeildDataDictionaries)
                    .HasForeignKey(d => d.IdTbSysForm)
                    .HasConstraintName("FK_TbSysFormFeildDataDictionary_TbSysForm");
            });

            modelBuilder.Entity<TbSysGroup>(entity =>
            {
                entity.ToTable("TbSysGroup");

                entity.HasIndex(e => e.Name, "IX_TbSysGroup")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Crc)
                    .HasMaxLength(50)
                    .HasColumnName("CRC");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TbSysPackage>(entity =>
            {
                entity.ToTable("TbSysPackage");

                entity.HasIndex(e => e.Name, "IX_TbSysPackage")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Crc)
                    .HasMaxLength(50)
                    .HasColumnName("CRC");

                entity.Property(e => e.LatinName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TbSysPackageForm>(entity =>
            {
                entity.HasKey(e => new { e.IdTbSysPackage, e.IdTbSysGroup, e.IdTbSysForm });

                entity.ToTable("TbSysPackageForm");

                entity.HasOne(d => d.IdTbSysFormNavigation)
                    .WithMany(p => p.TbSysPackageForms)
                    .HasForeignKey(d => d.IdTbSysForm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSysPackageForm_TbSysForm");

                entity.HasOne(d => d.IdTbSysGroupNavigation)
                    .WithMany(p => p.TbSysPackageForms)
                    .HasForeignKey(d => d.IdTbSysGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSysPackageForm_TbSysGroup");

                entity.HasOne(d => d.IdTbSysPackageNavigation)
                    .WithMany(p => p.TbSysPackageForms)
                    .HasForeignKey(d => d.IdTbSysPackage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSysPackageForm_TbSysPackage");
            });

            modelBuilder.Entity<TbSysStatus>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.TbName, e.FiName, e.Value });

                entity.ToTable("TbSysStatus");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.TbName)
                    .HasMaxLength(50)
                    .HasColumnName("tbName");

                entity.Property(e => e.FiName)
                    .HasMaxLength(50)
                    .HasColumnName("fiName");

                entity.Property(e => e.Value).HasColumnName("Value_");

                entity.Property(e => e.DisplayLabel).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.Root).HasColumnName("root");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .HasColumnName("Text_");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.TbSysStatuses)
                    .HasForeignKey(d => d.ShsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TbSysBaseStatus_SalMaly");
            });

            modelBuilder.Entity<TbSysTableDataDictionary>(entity =>
            {
                entity.ToTable("TbSysTableDataDictionary");

                entity.HasIndex(e => e.Name, "IX_TbSysTableDataDictionary_1")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Crc)
                    .HasMaxLength(50)
                    .HasColumnName("CRC");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Tel>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("TEL");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Accountant).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Adr)
                    .HasMaxLength(100)
                    .HasColumnName("ADR");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .HasColumnName("FAX");

                entity.Property(e => e.Mobil)
                    .HasMaxLength(100)
                    .HasColumnName("MOBIL");

                entity.Property(e => e.Modir)
                    .HasMaxLength(50)
                    .HasColumnName("modir");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Representative).HasMaxLength(50);

                entity.Property(e => e.Sho)
                    .HasMaxLength(100)
                    .HasColumnName("SHO");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Tels)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_TEL_SalMaly");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("user");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_karb")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.ActiveShob).HasColumnName("ACtiveShob");

                entity.Property(e => e.Admin).HasColumnName("ADMIN");

                entity.Property(e => e.Anb).HasColumnName("ANB");

                entity.Property(e => e.Andicator).HasColumnName("ANDICATOR");

                entity.Property(e => e.Ban).HasColumnName("BAN");

                entity.Property(e => e.Boos)
                    .HasMaxLength(50)
                    .HasColumnName("boos");

                entity.Property(e => e.Cal).HasColumnName("CAL");

                entity.Property(e => e.Callerid).HasColumnName("CALLERID");

                entity.Property(e => e.Casher).HasDefaultValueSql("((0))");

                entity.Property(e => e.Chd).HasColumnName("CHD");

                entity.Property(e => e.ChdVaz).HasColumnName("chd_vaz");

                entity.Property(e => e.Chebarcod).HasColumnName("CHEBARCOD");

                entity.Property(e => e.Chp).HasColumnName("CHP");

                entity.Property(e => e.ChpVaz).HasColumnName("chp_vaz");

                entity.Property(e => e.CodAnbs)
                    .HasMaxLength(1000)
                    .HasColumnName("cod_anbs");

                entity.Property(e => e.CodHcFfo).HasColumnName("cod_hc_ffo");

                entity.Property(e => e.CodHcFfoV).HasColumnName("cod_hc_ffo_v");

                entity.Property(e => e.CodHcs)
                    .HasMaxLength(1000)
                    .HasColumnName("cod_hcs");

                entity.Property(e => e.CodHmFacNaghd).HasColumnName("cod_hm_fac_naghd");

                entity.Property(e => e.CodHmFfo).HasColumnName("cod_hm_ffo");

                entity.Property(e => e.CodHmFfoV).HasColumnName("cod_hm_ffo_v");

                entity.Property(e => e.Col).HasColumnName("COL");

                entity.Property(e => e.CreditTar)
                    .HasMaxLength(20)
                    .HasColumnName("creditTar")
                    .HasDefaultValueSql("('9201019312303')");

                entity.Property(e => e.Delsalm).HasColumnName("DELSALM");

                entity.Property(e => e.Deltemp).HasColumnName("DELTEMP");

                entity.Property(e => e.FacVaz).HasColumnName("fac_vaz");

                entity.Property(e => e.Ffo).HasColumnName("FFO");

                entity.Property(e => e.Ffoa).HasColumnName("FFOA");

                entity.Property(e => e.Finder).HasColumnName("FINDER");

                entity.Property(e => e.Fkh).HasColumnName("FKH");

                entity.Property(e => e.Fkha).HasColumnName("FKHA");

                entity.Property(e => e.Fta).HasColumnName("FTA");

                entity.Property(e => e.Fto0).HasColumnName("FTO0");

                entity.Property(e => e.GAmar).HasColumnName("G_Amar");

                entity.Property(e => e.GAml).HasColumnName("G_AML");

                entity.Property(e => e.GCash).HasColumnName("g_cash");

                entity.Property(e => e.GChart).HasColumnName("G_CHART");

                entity.Property(e => e.GGcal).HasColumnName("G_GCAL");

                entity.Property(e => e.GKrd).HasColumnName("G_KRD");

                entity.Property(e => e.GResid).HasColumnName("G_RESID");

                entity.Property(e => e.GSha).HasColumnName("G_SHA");

                entity.Property(e => e.GShm).HasColumnName("G_SHM");

                entity.Property(e => e.GShom).HasColumnName("G_SHOM");

                entity.Property(e => e.GSod).HasColumnName("G_SOD");

                entity.Property(e => e.GSodZian).HasColumnName("G_SOD_ZIAN");

                entity.Property(e => e.GSodzin).HasColumnName("G_SODZIN");

                entity.Property(e => e.GSpy).HasColumnName("G_SPY");

                entity.Property(e => e.GTarDbs).HasColumnName("G_TAR_DBS");

                entity.Property(e => e.GTarzT).HasColumnName("G_TARZ_T");

                entity.Property(e => e.GTaz).HasColumnName("G_TAZ");

                entity.Property(e => e.Ge0).HasColumnName("GE0");

                entity.Property(e => e.Ge0Vaz).HasColumnName("ge0_vaz");

                entity.Property(e => e.Hes).HasColumnName("HES");

                entity.Property(e => e.Ho0).HasColumnName("HO0");

                entity.Property(e => e.Jan).HasColumnName("JAN");

                entity.Property(e => e.Kark).HasColumnName("KARK");

                entity.Property(e => e.Karkfor).HasColumnName("KARKFOR");

                entity.Property(e => e.Kart).HasColumnName("KART");

                entity.Property(e => e.Khad).HasColumnName("KHAD");

                entity.Property(e => e.Kind).HasColumnName("kind");

                entity.Property(e => e.Lisdaf).HasColumnName("LISDAF");

                entity.Property(e => e.LockGhTak).HasColumnName("LockGh_tak");

                entity.Property(e => e.Makesalm).HasColumnName("MAKESALM");

                entity.Property(e => e.Mfo).HasColumnName("MFO");

                entity.Property(e => e.Mkh).HasColumnName("MKH");

                entity.Property(e => e.Mobad).HasColumnName("MOBAD");

                entity.Property(e => e.Moe).HasColumnName("MOE");

                entity.Property(e => e.Mogh).HasColumnName("MOGH");

                entity.Property(e => e.Mos).HasColumnName("MOS");

                entity.Property(e => e.Moz).HasColumnName("MOZ");

                entity.Property(e => e.Mycomuter).HasColumnName("MYCOMUTER");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Newdor).HasColumnName("NEWDOR");

                entity.Property(e => e.NoPmGrid).HasColumnName("NoPM_grid");

                entity.Property(e => e.Pas)
                    .HasMaxLength(10)
                    .HasColumnName("PAS");

                entity.Property(e => e.Pathnet).HasColumnName("PATHNET");

                entity.Property(e => e.Peyam)
                    .HasMaxLength(200)
                    .HasColumnName("peyam");

                entity.Property(e => e.Pfa).HasColumnName("PFA");

                entity.Property(e => e.Pic)
                    .HasColumnType("image")
                    .HasColumnName("pic");

                entity.Property(e => e.Print).HasColumnName("PRINT");

                entity.Property(e => e.Projects).HasColumnName("PROJECTS");

                entity.Property(e => e.Rascheck).HasColumnName("RASCHECK");

                entity.Property(e => e.Reset).HasColumnName("RESET");

                entity.Property(e => e.Restart).HasColumnName("RESTART");

                entity.Property(e => e.RootId).HasColumnName("root_id");

                entity.Property(e => e.Sa0).HasColumnName("SA0");

                entity.Property(e => e.Sa0Dva).HasColumnName("SA0_DVA");

                entity.Property(e => e.Sa0Gat).HasColumnName("SA0_GAT");

                entity.Property(e => e.Sa0Move).HasColumnName("SA0_MOVE");

                entity.Property(e => e.Sa0Pva).HasColumnName("SA0_PVA");

                entity.Property(e => e.Salm).HasColumnName("SALM");

                entity.Property(e => e.Scm).HasColumnName("SCM");

                entity.Property(e => e.SetAnbP).HasColumnName("SET_ANB_P");

                entity.Property(e => e.Sets).HasColumnName("SETS");

                entity.Property(e => e.Shobe).HasColumnName("shobe");

                entity.Property(e => e.ShowOtheryear).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowtarS).HasColumnName("SHOWTAR_S");

                entity.Property(e => e.Sms).HasColumnName("SMS");

                entity.Property(e => e.Smscredit)
                    .HasMaxLength(20)
                    .HasColumnName("SMScredit")
                    .HasDefaultValueSql("('9201019312303')");

                entity.Property(e => e.Tel).HasColumnName("TEL");

                entity.Property(e => e.Testdata).HasColumnName("TESTDATA");

                entity.Property(e => e.Unzip).HasColumnName("UNZIP");

                entity.Property(e => e.User1).HasColumnName("USER");

                entity.Property(e => e.Vah).HasColumnName("VAH");

                entity.Property(e => e.Vizitor).HasColumnName("VIZITOR");

                entity.Property(e => e.Zip).HasColumnName("ZIP");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_karb_SalMaly");
            });

            modelBuilder.Entity<UserDatum>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Id, e.Name });

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Crc)
                    .HasMaxLength(50)
                    .HasColumnName("CRC");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .HasColumnName("Date_")
                    .IsFixedLength(true);

                entity.Property(e => e.GridData).HasColumnType("ntext");

                entity.Property(e => e.Kind).HasColumnName("kind");

                entity.Property(e => e.LockSerial).HasMaxLength(50);

                entity.Property(e => e.Permission).HasMaxLength(50);

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.UserData)
                    .HasForeignKey(d => d.ShsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserData_SalMaly");
            });

            modelBuilder.Entity<Vah>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("VAH");

                entity.HasIndex(e => new { e.ShsId, e.Vahed }, "IX_VAH")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Vahed)
                    .HasMaxLength(50)
                    .HasColumnName("VAHED");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Vahs)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_VAH_SalMaly");
            });

            modelBuilder.Entity<Vizitor>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Cod });

                entity.ToTable("vizitor");

                entity.HasIndex(e => new { e.ShsId, e.Name }, "IX_vizitor")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Adr)
                    .HasMaxLength(254)
                    .HasColumnName("ADR");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.Darvizitor).HasColumnName("DARVIZITOR");

                entity.Property(e => e.Moaref).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.TarJ)
                    .HasMaxLength(10)
                    .HasColumnName("tar_j");

                entity.Property(e => e.Tel)
                    .HasMaxLength(100)
                    .HasColumnName("TEL");

                entity.Property(e => e.Zamen).HasMaxLength(50);

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Vizitors)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_vizitor_SalMaly");
            });

            modelBuilder.Entity<VwBuy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Buy");

                entity.Property(e => e.ارزشافزوده).HasColumnName("ارزش_افزوده");

                entity.Property(e => e.تاریخایجاد)
                    .HasMaxLength(17)
                    .HasColumnName("تاریخ_ایجاد");

                entity.Property(e => e.تاریخخرید)
                    .HasMaxLength(10)
                    .HasColumnName("تاریخ_خرید");

                entity.Property(e => e.جمعکل).HasColumnName("جمع_کل");

                entity.Property(e => e.سازنده).HasMaxLength(50);

                entity.Property(e => e.قابلپرداخت).HasColumnName("قابل_پرداخت");

                entity.Property(e => e.ویرایشگر).HasMaxLength(50);
            });

            modelBuilder.Entity<VwBuyList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BuyList");

                entity.Property(e => e.انبار).HasMaxLength(50);

                entity.Property(e => e.تاریخخرید)
                    .HasMaxLength(10)
                    .HasColumnName("تاریخ_خرید");

                entity.Property(e => e.ساعتخرید)
                    .HasMaxLength(8)
                    .HasColumnName("ساعت_خرید");

                entity.Property(e => e.قابلپرداخت).HasColumnName("قابل_پرداخت");

                entity.Property(e => e.کالا).HasMaxLength(100);
            });

            modelBuilder.Entity<VwCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Company");

                entity.Property(e => e.شرکت).HasMaxLength(50);
            });

            modelBuilder.Entity<VwCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Customer");

                entity.Property(e => e.آدرس).HasMaxLength(100);

                entity.Property(e => e.تلفن).HasMaxLength(100);

                entity.Property(e => e.نام).HasMaxLength(50);

                entity.Property(e => e.همراه).HasMaxLength(100);
            });

            modelBuilder.Entity<VwProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Product");

                entity.Property(e => e.انبار).HasMaxLength(50);

                entity.Property(e => e.فیخرید).HasColumnName("فی_خرید");

                entity.Property(e => e.فیفروش).HasColumnName("فی_فروش");

                entity.Property(e => e.موجودیانبار).HasColumnName("موجودی انبار");

                entity.Property(e => e.واحد).HasMaxLength(50);

                entity.Property(e => e.کالا).HasMaxLength(100);
            });

            modelBuilder.Entity<VwProductFa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Product_Fa");

                entity.Property(e => e.انبار).HasMaxLength(50);

                entity.Property(e => e.فیخرید).HasColumnName("فی_خرید");

                entity.Property(e => e.فیفروش).HasColumnName("فی_فروش");

                entity.Property(e => e.موجودیانبار).HasColumnName("موجودی انبار");

                entity.Property(e => e.واحد).HasMaxLength(50);

                entity.Property(e => e.کالا).HasMaxLength(100);
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

            modelBuilder.Entity<VwStoreFa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Store_Fa");

                entity.Property(e => e.انبار)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.TbName, e.TbType, e.RequestNo, e.RequestNoSub, e.ReferenceNo });

                entity.ToTable("Workflow");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.TbName)
                    .HasMaxLength(50)
                    .HasColumnName("tbName");

                entity.Property(e => e.TbType)
                    .HasMaxLength(50)
                    .HasColumnName("tbType");

                entity.Property(e => e.RequestNo).HasColumnName("RequestNO");

                entity.Property(e => e.RequestNoSub).HasColumnName("RequestNO_sub");

                entity.Property(e => e.ReferenceNo).HasColumnName("ReferenceNO");

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .HasColumnName("Date_");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("Description_");

                entity.Property(e => e.FiName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fiName");

                entity.Property(e => e.FiNameSub)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fiName_sub");

                entity.Property(e => e.FiNameType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fiName_Type");

                entity.Property(e => e.Status).HasColumnName("status_");

                entity.Property(e => e.Time)
                    .HasMaxLength(8)
                    .HasColumnName("time_");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Workflows)
                    .HasForeignKey(d => d.ShsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workflow_SalMaly");
            });

            modelBuilder.Entity<WvSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wv_Sale");

                entity.Property(e => e.ارزشافزوده).HasColumnName("ارزش_افزوده");

                entity.Property(e => e.تاریخایجاد)
                    .HasMaxLength(17)
                    .HasColumnName("تاریخ_ایجاد");

                entity.Property(e => e.تاریخفروش)
                    .HasMaxLength(10)
                    .HasColumnName("تاریخ_فروش");

                entity.Property(e => e.جمعکل).HasColumnName("جمع_کل");

                entity.Property(e => e.سازنده).HasMaxLength(50);

                entity.Property(e => e.قابلپرداخت).HasColumnName("قابل_پرداخت");

                entity.Property(e => e.ویرایشگر).HasMaxLength(50);
            });

            modelBuilder.Entity<WvSaleList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("wv_SaleList");

                entity.Property(e => e.انبار).HasMaxLength(50);

                entity.Property(e => e.تاریخخرید)
                    .HasMaxLength(10)
                    .HasColumnName("تاریخ_خرید");

                entity.Property(e => e.ساعتخرید)
                    .HasMaxLength(8)
                    .HasColumnName("ساعت_خرید");

                entity.Property(e => e.قابلپرداخت).HasColumnName("قابل پرداخت");

                entity.Property(e => e.کالا).HasMaxLength(100);
            });

            modelBuilder.Entity<Yad>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Tar, e.Rad });

                entity.ToTable("YAD");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Rad).HasColumnName("rad");

                entity.Property(e => e.Yadasht)
                    .HasMaxLength(200)
                    .HasColumnName("YADASHT");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Yads)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_YAD_SalMaly");
            });

            modelBuilder.Entity<ZTempAgl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_agl");

                entity.Property(e => e.AbadC)
                    .HasMaxLength(254)
                    .HasColumnName("ABAD_C");

                entity.Property(e => e.BarcodC)
                    .HasMaxLength(100)
                    .HasColumnName("BARCOD_C");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodAnb2).HasColumnName("COD_ANB2");

                entity.Property(e => e.CodC).HasColumnName("COD_C");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.GhCol).HasColumnName("GH_COL");

                entity.Property(e => e.GhMasC).HasColumnName("GH_MAS_C");

                entity.Property(e => e.GhMin).HasColumnName("GH_MIN");

                entity.Property(e => e.GhMinhaz).HasColumnName("GH_MINHAZ");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.GhTak).HasColumnName("GH_TAK");

                entity.Property(e => e.GhZar).HasColumnName("GH_ZAR");

                entity.Property(e => e.Guaranty).HasColumnName("GUARANTY");

                entity.Property(e => e.Haz).HasColumnName("haz");

                entity.Property(e => e.MojC).HasColumnName("MOJ_C");

                entity.Property(e => e.MojFifo).HasColumnName("MOJ_FIFO");

                entity.Property(e => e.MojLifo).HasColumnName("MOJ_LIFO");

                entity.Property(e => e.MojZ).HasColumnName("MOJ_Z");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.NameAnb2)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB2");

                entity.Property(e => e.NameC)
                    .HasMaxLength(100)
                    .HasColumnName("NAME_C");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.Noecal)
                    .HasMaxLength(50)
                    .HasColumnName("NOECAL");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Ranandeh)
                    .HasMaxLength(254)
                    .HasColumnName("RANANDEH");

                entity.Property(e => e.Shom)
                    .HasMaxLength(254)
                    .HasColumnName("SHOM");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(254)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.TakhC).HasColumnName("TAKH_C");

                entity.Property(e => e.TakhTedC).HasColumnName("TAKH_TED_C");

                entity.Property(e => e.TarC)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_C");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TedC).HasColumnName("TED_C");

                entity.Property(e => e.TimeC)
                    .HasMaxLength(8)
                    .HasColumnName("TIME_C");

                entity.Property(e => e.Tozih2C)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH2_C");

                entity.Property(e => e.TozihC)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_C");

                entity.Property(e => e.TozihEng)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_ENG");

                entity.Property(e => e.Vah2C)
                    .HasMaxLength(50)
                    .HasColumnName("VAH2_C");

                entity.Property(e => e.VahC)
                    .HasMaxLength(50)
                    .HasColumnName("VAH_C");

                entity.Property(e => e.ZarC).HasColumnName("ZAR_C");

                entity.Property(e => e.ZarCol).HasColumnName("ZAR_COL");
            });

            modelBuilder.Entity<ZTempFfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_ffo");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<ZTempFkh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_fkh");

                entity.Property(e => e.AaMab).HasColumnName("AA_MAB");

                entity.Property(e => e.Chek).HasColumnName("CHEK");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodFpa).HasColumnName("COD_FPA");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHcF).HasColumnName("cod_hc_f");

                entity.Property(e => e.CodHcG).HasColumnName("cod_hc_g");

                entity.Property(e => e.CodHcV).HasColumnName("COD_HC_V");

                entity.Property(e => e.CodHcVi).HasColumnName("COD_HC_VI");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodHmF).HasColumnName("cod_hm_f");

                entity.Property(e => e.CodHmG).HasColumnName("cod_hm_g");

                entity.Property(e => e.CodHmV).HasColumnName("COD_HM_V");

                entity.Property(e => e.CodHmVi).HasColumnName("COD_HM_VI");

                entity.Property(e => e.CodSa).HasColumnName("COD_SA");

                entity.Property(e => e.GhFa).HasColumnName("GH_FA");

                entity.Property(e => e.GhMan).HasColumnName("GH_MAN");

                entity.Property(e => e.GhNa).HasColumnName("GH_NA");

                entity.Property(e => e.Haz).HasColumnName("HAZ");

                entity.Property(e => e.JamTed).HasColumnName("JAM_TED");

                entity.Property(e => e.JamZar).HasColumnName("JAM_ZAR");

                entity.Property(e => e.MabF).HasColumnName("mab_f");

                entity.Property(e => e.MabG).HasColumnName("mab_g");

                entity.Property(e => e.MabPar).HasColumnName("MAB_PAR");

                entity.Property(e => e.MabParC).HasColumnName("MAB_PAR_C");

                entity.Property(e => e.MabParN).HasColumnName("MAB_PAR_N");

                entity.Property(e => e.MabV).HasColumnName("MAB_V");

                entity.Property(e => e.MabVi).HasColumnName("MAB_VI");

                entity.Property(e => e.Naghd).HasColumnName("NAGHD");

                entity.Property(e => e.NoeF)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("NOE_F");

                entity.Property(e => e.NoePar)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_PAR");

                entity.Property(e => e.NoeTakh)
                    .HasMaxLength(10)
                    .HasColumnName("NOE_TAKH");

                entity.Property(e => e.ParHaz)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_HAZ");

                entity.Property(e => e.Shoms)
                    .HasMaxLength(50)
                    .HasColumnName("SHOMS");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Takh).HasColumnName("TAKH");

                entity.Property(e => e.TakhTed).HasColumnName("TAKH_TED");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.TarS)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TarV)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_V");

                entity.Property(e => e.Tavasot)
                    .HasMaxLength(50)
                    .HasColumnName("TAVASOT");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Vaz)
                    .HasMaxLength(20)
                    .HasColumnName("VAZ");
            });

            modelBuilder.Entity<ZTempGetMojCala>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_GetMojCala");

                entity.Property(e => e.TedC).HasColumnName("ted_c");
            });

            modelBuilder.Entity<ZTempReportAmlkardDaru>(entity =>
            {
                entity.HasKey(e => new { e.SpidHostName, e.ShsId, e.Cod });

                entity.ToTable("z_temp_report_amlkardDaru");

                entity.Property(e => e.SpidHostName)
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.MabForush1).HasColumnName("mabForush1");

                entity.Property(e => e.MabKharid).HasColumnName("mabKHarid");

                entity.Property(e => e.Mabforush).HasColumnName("mabforush");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Shom)
                    .HasMaxLength(50)
                    .HasColumnName("shom");

                entity.Property(e => e.TarS)
                    .HasMaxLength(254)
                    .HasColumnName("TAR_S");

                entity.Property(e => e.TedadForush).HasColumnName("tedadForush");

                entity.Property(e => e.TedadForush1).HasColumnName("tedadForush1");

                entity.Property(e => e.TedadKharid).HasColumnName("tedadKharid");
            });

            modelBuilder.Entity<ZTempReportCol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_report_col");

                entity.Property(e => e.Acronym2).HasMaxLength(20);

                entity.Property(e => e.Acronym3).HasMaxLength(20);

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodMos).HasColumnName("cod_mos");

                entity.Property(e => e.CodMoz).HasColumnName("COD_MOZ");

                entity.Property(e => e.CodMozJ).HasColumnName("COD_MOZ_J");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Mab2).HasColumnName("mab2");

                entity.Property(e => e.Mab3).HasColumnName("mab3");

                entity.Property(e => e.Mbd).HasColumnName("MBD");

                entity.Property(e => e.Mbs).HasColumnName("MBS");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Saat)
                    .HasMaxLength(8)
                    .HasColumnName("SAAT");

                entity.Property(e => e.Shog).HasColumnName("SHOG");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.SpidHostName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Tek).HasColumnName("TEK");

                entity.Property(e => e.Vaz).HasColumnName("VAZ");
            });

            modelBuilder.Entity<ZTempReportQcal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_report_qcal");

                entity.Property(e => e.Ava).HasColumnName("ava");

                entity.Property(e => e.Barcod)
                    .HasMaxLength(100)
                    .HasColumnName("BARCOD");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodAnb).HasColumnName("COD_ANB");

                entity.Property(e => e.CodHcT).HasColumnName("cod_hc_t");

                entity.Property(e => e.CodHmT).HasColumnName("cod_hm_t");

                entity.Property(e => e.Ffo).HasColumnName("ffo");

                entity.Property(e => e.FfoKhales).HasColumnName("ffo_khales");

                entity.Property(e => e.Ffoa).HasColumnName("ffoa");

                entity.Property(e => e.Fkh).HasColumnName("fkh");

                entity.Property(e => e.FkhKhales).HasColumnName("fkh_khales");

                entity.Property(e => e.Fkha).HasColumnName("fkha");

                entity.Property(e => e.Ftafrom).HasColumnName("ftafrom");

                entity.Property(e => e.Ftahav).HasColumnName("ftahav");

                entity.Property(e => e.Ftares).HasColumnName("ftares");

                entity.Property(e => e.Ftato).HasColumnName("ftato");

                entity.Property(e => e.GhAva).HasColumnName("gh_ava");

                entity.Property(e => e.GhFfo).HasColumnName("gh_ffo");

                entity.Property(e => e.GhFfoBaKha).HasColumnName("gh_ffo_Ba_kha");

                entity.Property(e => e.GhFfoKhales).HasColumnName("gh_ffo_khales");

                entity.Property(e => e.GhFfoKhalesBaKha).HasColumnName("gh_ffo_khales_ba_kha");

                entity.Property(e => e.GhFfoa).HasColumnName("gh_ffoa");

                entity.Property(e => e.GhFkh).HasColumnName("gh_fkh");

                entity.Property(e => e.GhFkhKhales).HasColumnName("gh_fkh_khales");

                entity.Property(e => e.GhFkha).HasColumnName("gh_fkha");

                entity.Property(e => e.GhFtafrom).HasColumnName("gh_ftafrom");

                entity.Property(e => e.GhFtahav).HasColumnName("gh_ftahav");

                entity.Property(e => e.GhFtares).HasColumnName("gh_ftares");

                entity.Property(e => e.GhFtato).HasColumnName("gh_ftato");

                entity.Property(e => e.GhKho).HasColumnName("gh_kho");

                entity.Property(e => e.GhLastKh).HasColumnName("GH_LAST_KH");

                entity.Property(e => e.GhMan).HasColumnName("gh_man");

                entity.Property(e => e.GhMfo).HasColumnName("gh_mfo");

                entity.Property(e => e.GhMin).HasColumnName("gh_min");

                entity.Property(e => e.GhMkh).HasColumnName("gh_mkh");

                entity.Property(e => e.GhMojG).HasColumnName("gh_moj_g");

                entity.Property(e => e.GhMojGVor).HasColumnName("gh_moj_g_vor");

                entity.Property(e => e.GhVor).HasColumnName("gh_vor");

                entity.Property(e => e.GhlastFo).HasColumnName("GHLAST_FO");

                entity.Property(e => e.Kho).HasColumnName("kho");

                entity.Property(e => e.KhoG).HasColumnName("kho_g");

                entity.Property(e => e.Man).HasColumnName("man");

                entity.Property(e => e.Mfo).HasColumnName("mfo");

                entity.Property(e => e.Mkh).HasColumnName("mkh");

                entity.Property(e => e.Moj).HasColumnName("MOJ");

                entity.Property(e => e.MojG).HasColumnName("moj_g");

                entity.Property(e => e.MojGVor).HasColumnName("moj_g_vor");

                entity.Property(e => e.MojNeed).HasColumnName("moj_need");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.NameAnb)
                    .HasMaxLength(50)
                    .HasColumnName("NAME_ANB");

                entity.Property(e => e.Noecal)
                    .HasMaxLength(50)
                    .HasColumnName("NOECAL");

                entity.Property(e => e.Pfa).HasColumnName("pfa");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Sod).HasColumnName("sod");

                entity.Property(e => e.SpidHostName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(500)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.TozihEng)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH_ENG");

                entity.Property(e => e.Vor).HasColumnName("vor");

                entity.Property(e => e.VorG).HasColumnName("vor_g");
            });

            modelBuilder.Entity<ZTempReportSa0>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_report_sa0");

                entity.Property(e => e.Acronym2).HasMaxLength(20);

                entity.Property(e => e.Acronym3).HasMaxLength(20);

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodMos).HasColumnName("cod_mos");

                entity.Property(e => e.CodMoz).HasColumnName("COD_MOZ");

                entity.Property(e => e.CodMozJ).HasColumnName("COD_MOZ_J");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Mab2).HasColumnName("mab2");

                entity.Property(e => e.Mab3).HasColumnName("mab3");

                entity.Property(e => e.Mbd).HasColumnName("MBD");

                entity.Property(e => e.Mbs).HasColumnName("MBS");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Saat)
                    .HasMaxLength(8)
                    .HasColumnName("SAAT");

                entity.Property(e => e.Shog).HasColumnName("SHOG");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.SpidHostName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Tek).HasColumnName("TEK");

                entity.Property(e => e.Vaz).HasColumnName("VAZ");
            });

            modelBuilder.Entity<ZTempReportTaz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_report_taz");

                entity.Property(e => e.ABed).HasColumnName("a_bed");

                entity.Property(e => e.ABes).HasColumnName("a_bes");

                entity.Property(e => e.CodHc).HasColumnName("COD_hc");

                entity.Property(e => e.CodHm).HasColumnName("COD_hm");

                entity.Property(e => e.CodMos)
                    .HasColumnName("cod_mos")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodR).HasColumnName("COD_R");

                entity.Property(e => e.DBed).HasColumnName("d_bed");

                entity.Property(e => e.DBes).HasColumnName("d_bes");

                entity.Property(e => e.Dargeh).HasColumnName("DARGEH");

                entity.Property(e => e.Etebar).HasColumnName("ETEBAR");

                entity.Property(e => e.KBed).HasColumnName("k_bed");

                entity.Property(e => e.KBes).HasColumnName("k_bes");

                entity.Property(e => e.MBed).HasColumnName("m_bed");

                entity.Property(e => e.MBes).HasColumnName("m_bes");

                entity.Property(e => e.Mah)
                    .HasMaxLength(20)
                    .HasColumnName("MAH");

                entity.Property(e => e.Masdod).HasColumnName("MASDOD");

                entity.Property(e => e.MoDa).HasColumnName("MO_DA");

                entity.Property(e => e.Noe)
                    .HasMaxLength(15)
                    .HasColumnName("NOE");

                entity.Property(e => e.NoeEs)
                    .HasMaxLength(50)
                    .HasColumnName("NOE_ES");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.SpidHostName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("SPID_Host_Name");

                entity.Property(e => e.Tafzil)
                    .HasMaxLength(500)
                    .HasColumnName("TAFZIL");

                entity.Property(e => e.TbCod).HasColumnName("TB_COD");

                entity.Property(e => e.TbName)
                    .HasMaxLength(10)
                    .HasColumnName("TB_NAME");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");
            });

            modelBuilder.Entity<ZTempSa0>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_sa0");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.Gat).HasColumnName("GAT");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");
            });

            modelBuilder.Entity<ZTempSan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("z_temp_san");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CodHc).HasColumnName("COD_HC");

                entity.Property(e => e.CodHm).HasColumnName("COD_HM");

                entity.Property(e => e.CodMoz).HasColumnName("COD_MOZ");

                entity.Property(e => e.CodMozJ).HasColumnName("COD_MOZ_J");

                entity.Property(e => e.CodProj).HasColumnName("COD_PROJ");

                entity.Property(e => e.CodShobe).HasColumnName("COD_shobe");

                entity.Property(e => e.Mab).HasColumnName("MAB");

                entity.Property(e => e.Mbd).HasColumnName("MBD");

                entity.Property(e => e.Mbs).HasColumnName("MBS");

                entity.Property(e => e.Moz)
                    .HasMaxLength(254)
                    .HasColumnName("MOZ");

                entity.Property(e => e.Noe)
                    .HasMaxLength(20)
                    .HasColumnName("NOE");

                entity.Property(e => e.Rad).HasColumnName("RAD");

                entity.Property(e => e.Saat)
                    .HasMaxLength(8)
                    .HasColumnName("SAAT");

                entity.Property(e => e.Shog).HasColumnName("SHOG");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Tar)
                    .HasMaxLength(10)
                    .HasColumnName("TAR");

                entity.Property(e => e.Tek).HasColumnName("TEK");

                entity.Property(e => e.Vaz).HasColumnName("VAZ");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
