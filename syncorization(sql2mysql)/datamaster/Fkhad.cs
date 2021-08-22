using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Fkhad
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Tar { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public double? GhFa { get; set; }
        public double? Takh { get; set; }
        public double? GhNa { get; set; }
        public double? Naghd { get; set; }
        public double? Chek { get; set; }
        public double? MabVarizi { get; set; }
        public double? GhMan { get; set; }
        public double? CodHcV { get; set; }
        public double? CodHmV { get; set; }
        public string Tozih { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
