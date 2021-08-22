using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Tel
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public string Sho { get; set; }
        public string Mobil { get; set; }
        public string Adr { get; set; }
        public string Fax { get; set; }
        public string Tozih { get; set; }
        public string CodEshterak { get; set; }
        public string Modir { get; set; }
        public string Representative { get; set; }
        public string Accountant { get; set; }
        public string Address2 { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
