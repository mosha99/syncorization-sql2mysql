using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Ge
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public double Rad { get; set; }
        public string Tar { get; set; }
        public string TarV { get; set; }
        public double? Mab { get; set; }
        public string Tozih { get; set; }
        public string Vaz { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public double? CodSa { get; set; }
        public double? MabDir { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
