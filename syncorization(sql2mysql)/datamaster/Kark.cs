using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Kark
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public bool Fal { get; set; }
        public string Name { get; set; }
        public string Shos { get; set; }
        public string Naf { get; set; }
        public string Madr { get; set; }
        public bool VazKh { get; set; }
        public string NameKha { get; set; }
        public string Adr { get; set; }
        public string Tel { get; set; }
        public string Shop { get; set; }
        public string Shok { get; set; }
        public string Shob { get; set; }
        public string Shod { get; set; }
        public double? CodFor { get; set; }
        public string NameFor { get; set; }
        public string MahK { get; set; }
        public string Tozih { get; set; }
        public string Shoh { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public bool Bimh { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
