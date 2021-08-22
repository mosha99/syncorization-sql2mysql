using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Moz2
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Moz { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
