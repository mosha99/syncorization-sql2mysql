using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class He
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public string Shom { get; set; }
        public string NameBa { get; set; }
        public string ShoBa { get; set; }
        public string Tarf { get; set; }
        public double? MojAv { get; set; }
        public double? Moj { get; set; }
        public string Tozih { get; set; }
        public double? Tarhch { get; set; }
        public double? TmpMoj { get; set; }
        public string Noe { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public string Shomsha { get; set; }
        public string Sheba { get; set; }
        public string Cart { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
