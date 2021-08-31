using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class VwBuyList
    {
        public int Year { get; set; }
        public double BuyId { get; set; }
        public double Num { get; set; }
        public double? ProductId { get; set; }
        public double? StoreId { get; set; }
        public string Store { get; set; }
        public string ProductName { get; set; }
        public double? Amount { get; set; }
        public double? Price { get; set; }
        public double? Total { get; set; }
        public double? Discount { get; set; }
        public double? FinalPrice { get; set; }
        public double? Unit { get; set; }
        public double? Amount2 { get; set; }
        public double? BookId { get; set; }
        public double? AccountId { get; set; }
        public string BuyDate { get; set; }
        public string BuyTime { get; set; }
    }
}
