using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Col
    {
        public int ShsId { get; set; }
        public double CodR { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public string Noe { get; set; }
        public bool MoDa { get; set; }
        public double? Moj { get; set; }
        public double? Moe { get; set; }
        public double? TmpMoj { get; set; }
        public double? TmpMojbs { get; set; }
        public string Mah { get; set; }
        public double? Dargeh { get; set; }
        public string NoeEs { get; set; }
        public string Coding { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
