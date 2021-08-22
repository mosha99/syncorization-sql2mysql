using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Moe
    {
        public int ShsId { get; set; }
        public double CodHc { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public double? Moj { get; set; }
        public double? TmpMoj { get; set; }
        public double? TmpMojbs { get; set; }
        public string Tozih { get; set; }
        public string Tafzil { get; set; }
        public bool Masdod { get; set; }
        public double? Etebar { get; set; }
        public string TbName { get; set; }
        public double? TbCod { get; set; }
        public int? IdTbSysCurrencies2 { get; set; }
        public int? IdTbSysCurrencies3 { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
