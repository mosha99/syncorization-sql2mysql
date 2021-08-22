using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Khad
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public double? MabM { get; set; }
        public double? MabS { get; set; }
        public string Tozih { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
