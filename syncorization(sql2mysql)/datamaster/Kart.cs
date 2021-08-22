using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Kart
    {
        public int ShsId { get; set; }
        public string Tar { get; set; }
        public double CodHc { get; set; }
        public double CodHm { get; set; }
        public string Vaz { get; set; }
        public string Sat1 { get; set; }
        public string Sat2 { get; set; }
        public string Tozih { get; set; }
        public string Tozih2 { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
