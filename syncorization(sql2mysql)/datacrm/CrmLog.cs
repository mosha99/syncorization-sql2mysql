using System;
using System.Collections.Generic;

#nullable disable

namespace data
{
    public partial class CrmLog
    {
        public int ShsId { get; set; }
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public string Tar { get; set; }
        public double? Mab { get; set; }
        public double? Takh { get; set; }
        public double? FactorCode { get; set; }
        public string TypeDiscount { get; set; }
        public int? IdAgreement { get; set; }
        public int? ShsIdFfo { get; set; }
        public string ShsIdFfoName { get; set; }

        public virtual CrmCustomer CrmCustomer { get; set; }
        public virtual SalMaly Shs { get; set; }
    }
}
