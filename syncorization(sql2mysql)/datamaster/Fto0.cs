using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Fto0
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public string Tozih { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
