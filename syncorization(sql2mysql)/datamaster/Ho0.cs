using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Ho0
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Tar { get; set; }
        public string Tozih { get; set; }
        public double? Ted { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public double? CodSa { get; set; }
        public string Vaz { get; set; }
        public double? CodSap { get; set; }
        public string TarP { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
