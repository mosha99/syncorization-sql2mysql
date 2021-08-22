using System;
using System.Collections.Generic;

#nullable disable

namespace data
{
    public partial class CrmAgreement
    {
        public int ShsId { get; set; }
        public string Name { get; set; }
        public int IdCompany { get; set; }
        public string Tar { get; set; }
        public double? Mabkol { get; set; }
        public string Sho { get; set; }
        public int Id { get; set; }
        public string Tar1 { get; set; }
        public string Tar2 { get; set; }
        public string Tozih { get; set; }
        public double? Darn { get; set; }
        public double? Darq { get; set; }
        public double? Dare { get; set; }
        public double? Darb { get; set; }
        public string Tozihn { get; set; }
        public string Tozihq { get; set; }
        public string Tozihe { get; set; }
        public string Tozihb { get; set; }
        public double? Creditq { get; set; }
        public double? Credite { get; set; }
        public double? Creditb { get; set; }
        public double? CodHce { get; set; }
        public double? CodHme { get; set; }
        public double? CodHcb { get; set; }
        public double? CodHmb { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
