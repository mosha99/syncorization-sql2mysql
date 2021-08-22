using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Mo
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public string Shoh { get; set; }
        public double? Phesab { get; set; }
        public double? Hesab { get; set; }
        public string Tozih { get; set; }
        public double? TmpHesab { get; set; }
        public string Fax { get; set; }
        public string Mobil { get; set; }
        public string Tafzil { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public string Namefather { get; set; }
        public string Shosh { get; set; }
        public string TarT { get; set; }
        public string TelWork { get; set; }
        public string Sadere { get; set; }
        public double? Takh { get; set; }
        public string NoeMos { get; set; }
        public string Mp3 { get; set; }
        public string Pic { get; set; }
        public string Joz { get; set; }
        public double? CodOld { get; set; }
        public string CodMeli { get; set; }
        public string CodHogogh { get; set; }
        public string CodParvandeh { get; set; }
        public string AdrWork { get; set; }
        public short? RozS { get; set; }
        public string CodeEqtesadi { get; set; }
        public int? CrmId { get; set; }
        public string PostalCode { get; set; }
        public string Modir { get; set; }
        public string Representative { get; set; }
        public string Accountant { get; set; }
        public string Address2 { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
