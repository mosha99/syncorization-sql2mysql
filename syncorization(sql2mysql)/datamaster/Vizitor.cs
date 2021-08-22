using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Vizitor
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public string Adr { get; set; }
        public string Tel { get; set; }
        public double? Darvizitor { get; set; }
        public string TarJ { get; set; }
        public string Zamen { get; set; }
        public string Moaref { get; set; }
        public double? DarHog { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
