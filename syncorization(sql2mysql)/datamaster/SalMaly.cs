using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class SalMaly
    {
        public SalMaly()
        {
            Aglkhads = new HashSet<Aglkhad>();
            Agls = new HashSet<Agl>();
            Anbs = new HashSet<Anb>();
            Bans = new HashSet<Ban>();
            Cals = new HashSet<Cal>();
            Chds = new HashSet<Chd>();
            Chps = new HashSet<Chp>();
            Cols = new HashSet<Col>();
            Facs = new HashSet<Fac>();
            FactorDeliveries = new HashSet<FactorDelivery>();
            Fkhads = new HashSet<Fkhad>();
            Fta = new HashSet<Ftum>();
            Fto0s = new HashSet<Fto0>();
            Ftols = new HashSet<Ftol>();
            Ge0s = new HashSet<Ge0>();
            Ges = new HashSet<Ge>();
            Hes = new HashSet<He>();
            Ho0s = new HashSet<Ho0>();
            Hogs = new HashSet<Hog>();
            Karkfors = new HashSet<Karkfor>();
            Karks = new HashSet<Kark>();
            Karts = new HashSet<Kart>();
            Khads = new HashSet<Khad>();
            Moes = new HashSet<Moe>();
            Mos = new HashSet<Mo>();
            Moz2s = new HashSet<Moz2>();
            Mozs = new HashSet<Moz>();
            Projects = new HashSet<Project>();
            Sa0s = new HashSet<Sa0>();
            Sans = new HashSet<San>();
            Shobes = new HashSet<Shobe>();
            Spies = new HashSet<Spy>();
            Tafcals = new HashSet<Tafcal>();
            Tafs = new HashSet<Taf>();
            TbSysCurrencies = new HashSet<TbSysCurrency>();
            TbSysStatuses = new HashSet<TbSysStatus>();
            Tels = new HashSet<Tel>();
            UserData = new HashSet<UserDatum>();
            Users = new HashSet<User>();
            Vahs = new HashSet<Vah>();
            Vizitors = new HashSet<Vizitor>();
            Workflows = new HashSet<Workflow>();
            Yads = new HashSet<Yad>();
        }

        public int ShsId { get; set; }
        public int Root { get; set; }
        public int Sal { get; set; }

        public virtual Sherkat RootNavigation { get; set; }
        public virtual Tan Tan { get; set; }
        public virtual ICollection<Aglkhad> Aglkhads { get; set; }
        public virtual ICollection<Agl> Agls { get; set; }
        public virtual ICollection<Anb> Anbs { get; set; }
        public virtual ICollection<Ban> Bans { get; set; }
        public virtual ICollection<Cal> Cals { get; set; }
        public virtual ICollection<Chd> Chds { get; set; }
        public virtual ICollection<Chp> Chps { get; set; }
        public virtual ICollection<Col> Cols { get; set; }
        public virtual ICollection<Fac> Facs { get; set; }
        public virtual ICollection<FactorDelivery> FactorDeliveries { get; set; }
        public virtual ICollection<Fkhad> Fkhads { get; set; }
        public virtual ICollection<Ftum> Fta { get; set; }
        public virtual ICollection<Fto0> Fto0s { get; set; }
        public virtual ICollection<Ftol> Ftols { get; set; }
        public virtual ICollection<Ge0> Ge0s { get; set; }
        public virtual ICollection<Ge> Ges { get; set; }
        public virtual ICollection<He> Hes { get; set; }
        public virtual ICollection<Ho0> Ho0s { get; set; }
        public virtual ICollection<Hog> Hogs { get; set; }
        public virtual ICollection<Karkfor> Karkfors { get; set; }
        public virtual ICollection<Kark> Karks { get; set; }
        public virtual ICollection<Kart> Karts { get; set; }
        public virtual ICollection<Khad> Khads { get; set; }
        public virtual ICollection<Moe> Moes { get; set; }
        public virtual ICollection<Mo> Mos { get; set; }
        public virtual ICollection<Moz2> Moz2s { get; set; }
        public virtual ICollection<Moz> Mozs { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Sa0> Sa0s { get; set; }
        public virtual ICollection<San> Sans { get; set; }
        public virtual ICollection<Shobe> Shobes { get; set; }
        public virtual ICollection<Spy> Spies { get; set; }
        public virtual ICollection<Tafcal> Tafcals { get; set; }
        public virtual ICollection<Taf> Tafs { get; set; }
        public virtual ICollection<TbSysCurrency> TbSysCurrencies { get; set; }
        public virtual ICollection<TbSysStatus> TbSysStatuses { get; set; }
        public virtual ICollection<Tel> Tels { get; set; }
        public virtual ICollection<UserDatum> UserData { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Vah> Vahs { get; set; }
        public virtual ICollection<Vizitor> Vizitors { get; set; }
        public virtual ICollection<Workflow> Workflows { get; set; }
        public virtual ICollection<Yad> Yads { get; set; }
    }
}
