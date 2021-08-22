using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Aglkhad
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public double Rad { get; set; }
        public double? CodKhad { get; set; }
        public double? Ted { get; set; }
        public double? GhTak { get; set; }
        public double? GhCol { get; set; }
        public double? Takh { get; set; }
        public double? GhNa { get; set; }
        public string Tozih { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
