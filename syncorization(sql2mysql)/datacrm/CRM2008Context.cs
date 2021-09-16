using System;
using System.IO;
using DataEditor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;
using DataEditor.myClass;

#nullable disable

namespace data
{
    public partial class CRM2008Context : DbContext
    {
        public CRM2008Context()
        {
        }

        public CRM2008Context(DbContextOptions<CRM2008Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CrmAgreement> CrmAgreements { get; set; }
        public virtual DbSet<CrmCompany> CrmCompanies { get; set; }
        public virtual DbSet<CrmCustomer> CrmCustomers { get; set; }
        public virtual DbSet<CrmDiscount> CrmDiscounts { get; set; }
        public virtual DbSet<CrmLog> CrmLogs { get; set; }
        public virtual DbSet<CrmSetting> CrmSettings { get; set; }
        public virtual DbSet<CrmSmssender> CrmSmssenders { get; set; }
        public virtual DbSet<DbInfo> DbInfos { get; set; }
        public virtual DbSet<Karbar> Karbars { get; set; }
        public virtual DbSet<SalMaly> SalMalies { get; set; }
        public virtual DbSet<Sherkat> Sherkats { get; set; }

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

                string cs = $"Data Source={myseting.DbSuorse};Persist Security Info=True;Initial Catalog={myseting.DbName1};User ID={myseting.SqlUsername };Password={myseting.SqlPassword};";
                Console.WriteLine(cs);

                optionsBuilder.UseSqlServer(cs);



                //TextEditor text = new TextEditor("App_Data/CS.txt");
                //string cs = text.Reader();
                Console.WriteLine(cs);
                optionsBuilder.UseSqlServer(cs); 
                //Console.WriteLine("StartLog ********************************************************************");
                //optionsBuilder.LogTo(Console.WriteLine);
               // Console.WriteLine("EndLog ********************************************************************");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<CrmAgreement>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Name });

                entity.ToTable("CRM_Agreement");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.CodHcb).HasColumnName("cod_hcb");

                entity.Property(e => e.CodHce).HasColumnName("cod_hce");

                entity.Property(e => e.CodHmb).HasColumnName("cod_hmb");

                entity.Property(e => e.CodHme).HasColumnName("cod_hme");

                entity.Property(e => e.Creditb).HasColumnName("creditb");

                entity.Property(e => e.Credite).HasColumnName("credite");

                entity.Property(e => e.Creditq).HasColumnName("creditq");

                entity.Property(e => e.Darb).HasColumnName("darb");

                entity.Property(e => e.Dare).HasColumnName("dare");

                entity.Property(e => e.Darn).HasColumnName("darn");

                entity.Property(e => e.Darq).HasColumnName("darq");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Mabkol).HasColumnName("mabkol");

                entity.Property(e => e.Sho)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("sho");

                entity.Property(e => e.Tar)
                    .HasMaxLength(8)
                    .HasColumnName("tar");

                entity.Property(e => e.Tar1)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("tar1");

                entity.Property(e => e.Tar2)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("tar2");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(200)
                    .HasColumnName("tozih");

                entity.Property(e => e.Tozihb)
                    .HasMaxLength(100)
                    .HasColumnName("tozihb");

                entity.Property(e => e.Tozihe)
                    .HasMaxLength(100)
                    .HasColumnName("tozihe");

                entity.Property(e => e.Tozihn)
                    .HasMaxLength(100)
                    .HasColumnName("tozihn");

                entity.Property(e => e.Tozihq)
                    .HasMaxLength(100)
                    .HasColumnName("tozihq");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.CrmAgreements)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_CRM_Agreement_SalMaly");
            });

            modelBuilder.Entity<CrmCompany>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Name });

                entity.ToTable("CRM_Company");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Delegate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delegate");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("fax");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("tel");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(200)
                    .HasColumnName("tozih");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.CrmCompanies)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_CRM_Company_SalMaly");
            });

            modelBuilder.Entity<CrmCustomer>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Id });

                entity.ToTable("CRM_Customer");

                entity.HasIndex(e => e.CodeMelli, "IX_CRM_Customer")
                    .IsUnique();

                entity.HasIndex(e => e.CodEshterak, "IX_CRM_Customer_1")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Adder)
                    .HasMaxLength(50)
                    .HasColumnName("adder");

                entity.Property(e => e.Adr)
                    .HasMaxLength(100)
                    .HasColumnName("ADR");

                entity.Property(e => e.BinCvv2)
                    .HasMaxLength(4)
                    .HasColumnName("binCVV2");

                entity.Property(e => e.BinExpdate)
                    .HasMaxLength(7)
                    .HasColumnName("binEXPDATE");

                entity.Property(e => e.Bincart)
                    .HasMaxLength(20)
                    .HasColumnName("bincart");

                entity.Property(e => e.CartKind)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'اشتراک')");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.CodEshterak)
                    .HasMaxLength(50)
                    .HasColumnName("cod_Eshterak");

                entity.Property(e => e.CodeMelli).HasMaxLength(50);

                entity.Property(e => e.Editor)
                    .HasMaxLength(50)
                    .HasColumnName("editor");

                entity.Property(e => e.Father)
                    .HasMaxLength(15)
                    .HasColumnName("FATHER");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .HasColumnName("FAX");

                entity.Property(e => e.Homecode)
                    .HasMaxLength(10)
                    .HasColumnName("HOMECODE");

                entity.Property(e => e.Homephone)
                    .HasMaxLength(12)
                    .HasColumnName("HOMEPHONE");

                entity.Property(e => e.IdCompany).HasColumnName("ID_Company");

                entity.Property(e => e.Job)
                    .HasMaxLength(100)
                    .HasColumnName("job");

                entity.Property(e => e.Lottery)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .HasColumnName("mail");

                entity.Property(e => e.Mobil)
                    .HasMaxLength(100)
                    .HasColumnName("MOBIL");

                entity.Property(e => e.MosId).HasColumnName("Mos_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Namel)
                    .HasMaxLength(50)
                    .HasColumnName("NAMEL");

                entity.Property(e => e.Pas)
                    .HasMaxLength(50)
                    .HasColumnName("pas");

                entity.Property(e => e.Scode)
                    .HasMaxLength(12)
                    .HasColumnName("SCODE");

                entity.Property(e => e.SendSms).HasColumnName("SendSMS");

                entity.Property(e => e.Sex).HasColumnName("SEX");

                entity.Property(e => e.Sho)
                    .HasMaxLength(100)
                    .HasColumnName("SHO");

                entity.Property(e => e.Sodor)
                    .HasMaxLength(15)
                    .HasColumnName("SODOR");

                entity.Property(e => e.Sstndrdcode)
                    .HasMaxLength(16)
                    .HasColumnName("SSTNDRDCODE");

                entity.Property(e => e.Tahol).HasColumnName("TAHOL");

                entity.Property(e => e.TarEdit)
                    .HasMaxLength(8)
                    .HasColumnName("tar_edit");

                entity.Property(e => e.TarEz)
                    .HasMaxLength(8)
                    .HasColumnName("tar_ez");

                entity.Property(e => e.TarKasianD)
                    .HasMaxLength(8)
                    .HasColumnName("tar_kasian_d");

                entity.Property(e => e.TarKasianT)
                    .HasMaxLength(8)
                    .HasColumnName("tar_kasian_t");

                entity.Property(e => e.TarS)
                    .HasMaxLength(8)
                    .HasColumnName("tar_s");

                entity.Property(e => e.TarTavalod)
                    .HasMaxLength(8)
                    .HasColumnName("tar_tavalod");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(254)
                    .HasColumnName("TOZIH");

                entity.Property(e => e.Workaddr)
                    .HasMaxLength(50)
                    .HasColumnName("WORKADDR");

                entity.Property(e => e.Workcode)
                    .HasMaxLength(10)
                    .HasColumnName("WORKCODE");

                entity.Property(e => e.Workphone)
                    .HasMaxLength(12)
                    .HasColumnName("WORKPHONE");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_CRM_Customer_SalMaly");
            });

            modelBuilder.Entity<CrmDiscount>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.IdCustomer, e.IdAgreement })
                    .HasName("PK_CRM_Discount_1");

                entity.ToTable("CRM_Discount");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.IdCustomer).HasColumnName("ID_Customer");

                entity.Property(e => e.IdAgreement).HasColumnName("ID_Agreement");

                entity.Property(e => e.CodHcb).HasColumnName("cod_hcb");

                entity.Property(e => e.CodHce).HasColumnName("cod_hce");

                entity.Property(e => e.CodHmb).HasColumnName("cod_hmb");

                entity.Property(e => e.CodHme).HasColumnName("cod_hme");

                entity.Property(e => e.Creditb).HasColumnName("creditb");

                entity.Property(e => e.Credite).HasColumnName("credite");

                entity.Property(e => e.Creditq).HasColumnName("creditq");

                entity.Property(e => e.Darb).HasColumnName("darb");

                entity.Property(e => e.Dare).HasColumnName("dare");

                entity.Property(e => e.Darn).HasColumnName("darn");

                entity.Property(e => e.Darq).HasColumnName("darq");

                entity.Property(e => e.Tar1)
                    .HasMaxLength(8)
                    .HasColumnName("tar1");

                entity.Property(e => e.Tar2)
                    .HasMaxLength(8)
                    .HasColumnName("tar2");

                entity.Property(e => e.Tozih)
                    .HasMaxLength(100)
                    .HasColumnName("tozih");

                entity.Property(e => e.Tozihb)
                    .HasMaxLength(100)
                    .HasColumnName("tozihb");

                entity.Property(e => e.Tozihe)
                    .HasMaxLength(100)
                    .HasColumnName("tozihe");

                entity.Property(e => e.Tozihn)
                    .HasMaxLength(100)
                    .HasColumnName("tozihn");

                entity.Property(e => e.Tozihq)
                    .HasMaxLength(100)
                    .HasColumnName("tozihq");
            });

            modelBuilder.Entity<CrmLog>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Id, e.IdCustomer });

                entity.ToTable("CRM_log");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdCustomer).HasColumnName("ID_Customer");

                entity.Property(e => e.FactorCode).HasColumnName("factor_code");

                entity.Property(e => e.IdAgreement).HasColumnName("ID_Agreement");

                entity.Property(e => e.Mab).HasColumnName("mab");

                entity.Property(e => e.ShsIdFfo).HasColumnName("shs_id_ffo");

                entity.Property(e => e.ShsIdFfoName)
                    .HasMaxLength(50)
                    .HasColumnName("shs_id_ffo_name");

                entity.Property(e => e.Takh).HasColumnName("takh");

                entity.Property(e => e.Tar)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("tar");

                entity.Property(e => e.TypeDiscount).HasMaxLength(50);

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.CrmLogs)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_CRM_log_SalMaly");

                entity.HasOne(d => d.CrmCustomer)
                    .WithMany(p => p.CrmLogs)
                    .HasForeignKey(d => new { d.ShsId, d.IdCustomer })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CRM_log_CRM_Customer");
            });

            modelBuilder.Entity<CrmSetting>(entity =>
            {
                entity.HasKey(e => e.ShsId);

                entity.ToTable("CRM_Setting");

                entity.Property(e => e.ShsId)
                    .ValueGeneratedNever()
                    .HasColumnName("SHS_ID");

                entity.Property(e => e.FacRound).HasColumnName("facRound");

                entity.Property(e => e.FacTozih).HasMaxLength(50);

                entity.Property(e => e.FacTozihEzdevaj).HasMaxLength(50);

                entity.Property(e => e.FacTozihPersonelDiscount).HasMaxLength(50);

                entity.Property(e => e.FacTozihTavalod).HasMaxLength(50);

                entity.Property(e => e.FactozihKasian).HasMaxLength(50);

                entity.Property(e => e.Host)
                    .HasMaxLength(200)
                    .HasColumnName("Host_");

                entity.Property(e => e.KasianCodHc).HasColumnName("kasian_cod_hc");

                entity.Property(e => e.KasianCodHmB).HasColumnName("kasian_cod_hm_b");

                entity.Property(e => e.KasianCodHmE).HasColumnName("kasian_cod_hm_e");

                entity.Property(e => e.KasianCodHmM).HasColumnName("kasian_cod_hm_m");

                entity.Property(e => e.KasianCodHmM2).HasColumnName("kasian_cod_hm_m2");

                entity.Property(e => e.LibKey).HasMaxLength(200);

                entity.Property(e => e.MerchNumber)
                    .HasMaxLength(50)
                    .HasColumnName("merch_number");

                entity.Property(e => e.MerchNumber2)
                    .HasMaxLength(50)
                    .HasColumnName("merch_number2");

                entity.Property(e => e.MsgAdd)
                    .HasMaxLength(200)
                    .HasColumnName("MsgADD");

                entity.Property(e => e.MsgAddFffo).HasMaxLength(100);

                entity.Property(e => e.MsgAddMfo).HasMaxLength(100);

                entity.Property(e => e.MsgDel).HasMaxLength(100);

                entity.Property(e => e.MsgEdit).HasMaxLength(200);

                entity.Property(e => e.MsgEzdevaj).HasMaxLength(200);

                entity.Property(e => e.MsgOmoomi).HasMaxLength(200);

                entity.Property(e => e.MsgOmoomi2).HasMaxLength(200);

                entity.Property(e => e.MsgTavalod).HasMaxLength(200);

                entity.Property(e => e.Msgffo1)
                    .HasMaxLength(200)
                    .HasColumnName("Msgffo_1");

                entity.Property(e => e.Msgffo2)
                    .HasMaxLength(200)
                    .HasColumnName("Msgffo_2");

                entity.Property(e => e.Msgffo3)
                    .HasMaxLength(200)
                    .HasColumnName("Msgffo_3");

                entity.Property(e => e.Msgffo4)
                    .HasMaxLength(200)
                    .HasColumnName("Msgffo_4");

                entity.Property(e => e.Msgffo5)
                    .HasMaxLength(200)
                    .HasColumnName("Msgffo_5");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.ShsIdFfo).HasColumnName("shs_id_FFO");

                entity.Property(e => e.Smstype)
                    .HasMaxLength(50)
                    .HasColumnName("SMSTYpe");

                entity.Property(e => e.Takh)
                    .HasColumnType("ntext")
                    .HasColumnName("takh");

                entity.Property(e => e.TerminalDelpass)
                    .HasMaxLength(50)
                    .HasColumnName("terminalDelpass");

                entity.Property(e => e.TerminalDelpass2)
                    .HasMaxLength(50)
                    .HasColumnName("terminalDelpass2");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .HasColumnName("terminal_id");

                entity.Property(e => e.TerminalId2)
                    .HasMaxLength(50)
                    .HasColumnName("terminal_id2");

                entity.Property(e => e.TerminalUser)
                    .HasMaxLength(50)
                    .HasColumnName("terminalUser");

                entity.Property(e => e.TerminalUser2)
                    .HasMaxLength(50)
                    .HasColumnName("terminalUser2");

                entity.Property(e => e.Terminalpass)
                    .HasMaxLength(50)
                    .HasColumnName("terminalpass");

                entity.Property(e => e.Terminalpass2)
                    .HasMaxLength(50)
                    .HasColumnName("terminalpass2");

                entity.Property(e => e.TypeDiscount).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Shs)
                    .WithOne(p => p.CrmSetting)
                    .HasForeignKey<CrmSetting>(d => d.ShsId)
                    .HasConstraintName("FK_CRM_Setting_SalMaly");
            });

            modelBuilder.Entity<CrmSmssender>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Id, e.IdCustomer });

                entity.ToTable("CRM_SMSSender");

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdCustomer).HasColumnName("ID_Customer");

                entity.Property(e => e.Matn)
                    .HasMaxLength(500)
                    .HasColumnName("matn");

                entity.Property(e => e.ShsIdFfo).HasColumnName("shs_id_ffo");

                entity.Property(e => e.ShsIdFfoName)
                    .HasMaxLength(50)
                    .HasColumnName("shs_id_ffo_name");

                entity.Property(e => e.Tar)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("tar");

                entity.Property(e => e.Vaz).HasColumnName("vaz");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.CrmSmssenders)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_CRM_SMSSender_SalMaly");

                entity.HasOne(d => d.CrmCustomer)
                    .WithMany(p => p.CrmSmssenders)
                    .HasForeignKey(d => new { d.ShsId, d.IdCustomer })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CRM_SMSSender_CRM_Customer");
            });

            modelBuilder.Entity<DbInfo>(entity =>
            {
                entity.HasKey(e => e.Version);

                entity.ToTable("db_info");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .HasColumnName("version");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment");
            });

            modelBuilder.Entity<Karbar>(entity =>
            {
                entity.HasKey(e => new { e.ShsId, e.Id });

                entity.ToTable("karbar");

                entity.HasIndex(e => e.Name, "IX_karbar")
                    .IsUnique();

                entity.Property(e => e.ShsId).HasColumnName("SHS_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaddCrmAgreement).HasColumnName("baddCRM_Agreement");

                entity.Property(e => e.BaddCrmCompany).HasColumnName("baddCRM_Company");

                entity.Property(e => e.BaddCrmCustomer).HasColumnName("BaddCRM_Customer");

                entity.Property(e => e.BaddCrmDiscount).HasColumnName("baddCRM_Discount");

                entity.Property(e => e.BaddCrmSmssender).HasColumnName("baddCRM_SMSSender");

                entity.Property(e => e.BdelCrmAgreement).HasColumnName("bdelCRM_Agreement");

                entity.Property(e => e.BdelCrmCompany).HasColumnName("bdelCRM_Company");

                entity.Property(e => e.BdelCrmCustomer).HasColumnName("BdelCRM_Customer");

                entity.Property(e => e.BdelCrmDiscount).HasColumnName("bdelCRM_Discount");

                entity.Property(e => e.BdelCrmLog).HasColumnName("bdelCRM_log");

                entity.Property(e => e.BdelCrmSmssender).HasColumnName("bdelCRM_SMSSender");

                entity.Property(e => e.BeditCrmAgreement).HasColumnName("beditCRM_Agreement");

                entity.Property(e => e.BeditCrmCompany).HasColumnName("beditCRM_Company");

                entity.Property(e => e.BeditCrmCustomer).HasColumnName("BeditCRM_Customer");

                entity.Property(e => e.BeditCrmDiscount).HasColumnName("beditCRM_Discount");

                entity.Property(e => e.BeditCrmSetting).HasColumnName("beditCRM_Setting");

                entity.Property(e => e.BeditCrmSmssender).HasColumnName("beditCRM_SMSSender");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Pas)
                    .HasMaxLength(255)
                    .HasColumnName("pas");

                entity.Property(e => e.TsCrmAgreement).HasColumnName("tsCRM_Agreement");

                entity.Property(e => e.TsCrmCompany).HasColumnName("tsCRM_Company");

                entity.Property(e => e.TsCrmCustomer).HasColumnName("tsCRM_Customer");

                entity.Property(e => e.TsCrmDiscount).HasColumnName("tsCRM_Discount");

                entity.Property(e => e.TsCrmSetting).HasColumnName("tsCRM_Setting");

                entity.Property(e => e.TsCrmSmssender).HasColumnName("tsCRM_SMSSender");

                entity.Property(e => e.Tskarbar).HasColumnName("tskarbar");

                entity.Property(e => e.TsrepCrmAgreement).HasColumnName("tsrepCRM_Agreement");

                entity.Property(e => e.TsrepCrmCompany).HasColumnName("tsrepCRM_Company");

                entity.Property(e => e.TsrepCrmCustomer).HasColumnName("tsrepCRM_Customer");

                entity.Property(e => e.TsrepCrmDiscount).HasColumnName("tsrepCRM_Discount");

                entity.Property(e => e.TsrepCrmLog).HasColumnName("tsrepCRM_log");

                entity.HasOne(d => d.Shs)
                    .WithMany(p => p.Karbars)
                    .HasForeignKey(d => d.ShsId)
                    .HasConstraintName("FK_karbar_SalMaly");
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

            modelBuilder.Entity<Sherkat>(entity =>
            {
                entity.ToTable("SHerkat");

                entity.HasIndex(e => e.Name, "IX_Sherkat")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
