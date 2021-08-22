using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Vah
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Vahed { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
