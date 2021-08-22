using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class FactorDelivery
    {
        public int ShsId { get; set; }
        public string NoeF { get; set; }
        public double Cod { get; set; }
        public int Rad { get; set; }
        public double? CodC { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public int? Status { get; set; }
        public double? Amount { get; set; }
        public string Commnet { get; set; }
        public int? UserId { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
