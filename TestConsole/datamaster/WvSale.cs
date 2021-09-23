using System;
using System.Collections.Generic;

#nullable disable

namespace TestConsole.datamaster
{
    public partial class WvSale
    {
        public int Year { get; set; }
        public double Id { get; set; }
        public string SaleDate { get; set; }
        public double? Total { get; set; }
        public double? Discount { get; set; }
        public double? Discount2 { get; set; }
        public double? Vat { get; set; }
        public double? Payment { get; set; }
        public double? Cash { get; set; }
        public double? Cheque { get; set; }
        public double? Deposit { get; set; }
        public double? Remaining { get; set; }
        public double? BookId { get; set; }
        public double? AccountId { get; set; }
        public string Creator { get; set; }
        public string Editor { get; set; }
        public string CrateDate { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
    }
}
