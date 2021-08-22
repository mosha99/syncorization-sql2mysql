using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Taf
    {
        public int ShsId { get; set; }
        public double? CodR { get; set; }
        public double Cod { get; set; }
        public string Tafzil { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
