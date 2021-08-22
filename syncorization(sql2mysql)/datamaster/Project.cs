using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Project
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public string TarS { get; set; }
        public string TarT { get; set; }
        public bool Takmil { get; set; }
        public double? Mab { get; set; }
        public string TarP { get; set; }
        public string TarSS { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
