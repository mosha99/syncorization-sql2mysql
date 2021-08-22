using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Tafcal
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public double? CodR { get; set; }
        public string Tafzil { get; set; }
        public string TbEn { get; set; }
        public string TbFa { get; set; }
        public string FiEn { get; set; }
        public string FiFa { get; set; }
        public string FfoNoe { get; set; }
        public double? GhFok { get; set; }
        public double? GhFoj { get; set; }
        public double? GhFo { get; set; }
        public double? Takh { get; set; }
        public double? TakhZar { get; set; }
        public int? RozS { get; set; }
        public double? Darvizitor { get; set; }
        public double? HadTedffo { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
