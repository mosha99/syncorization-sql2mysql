using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Ftum
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Tar { get; set; }
        public string Tozih { get; set; }
        public double? Haz { get; set; }
        public double? CodSa { get; set; }
        public string Noe { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public double? CodAnb1 { get; set; }
        public double? CodAnb2 { get; set; }
        public double? Shg1 { get; set; }
        public double? Shg2 { get; set; }
        public string TarTo { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
