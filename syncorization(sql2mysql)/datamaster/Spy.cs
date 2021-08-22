using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Spy
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Tar { get; set; }
        public string Time { get; set; }
        public string Ban { get; set; }
        public string Aml { get; set; }
        public string User { get; set; }
        public string Comnam { get; set; }
        public string Onv { get; set; }
        public string Tozih { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
