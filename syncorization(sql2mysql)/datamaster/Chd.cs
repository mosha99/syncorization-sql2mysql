using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Chd
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Shoms { get; set; }
        public string TarD { get; set; }
        public string TarS { get; set; }
        public double? Mab { get; set; }
        public string Vaz { get; set; }
        public string NameBa { get; set; }
        public string ShoBa { get; set; }
        public double? CodSad { get; set; }
        public double? CodSav { get; set; }
        public string Tozih { get; set; }
        public double? CodHm { get; set; }
        public double? CodHc { get; set; }
        public double? CodHcV { get; set; }
        public double? CodHmV { get; set; }
        public string TarV { get; set; }
        public string Shog { get; set; }
        public bool Edg { get; set; }
        public string TbFac { get; set; }
        public double? CodFac { get; set; }
        public string Vazha { get; set; }
        public double? CodProj { get; set; }
        public double? CodShobe { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
