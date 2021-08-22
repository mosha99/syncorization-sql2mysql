using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Chp
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string TarS { get; set; }
        public double? Mab { get; set; }
        public double? CodHe { get; set; }
        public string TarP { get; set; }
        public double? CodSas { get; set; }
        public string Vaz { get; set; }
        public string Tozih { get; set; }
        public string Shoms { get; set; }
        public double? CodSap { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public string TarV { get; set; }
        public bool Edg { get; set; }
        public string TbFac { get; set; }
        public double? CodFac { get; set; }
        public double? CodProj { get; set; }
        public double? CodShobe { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
