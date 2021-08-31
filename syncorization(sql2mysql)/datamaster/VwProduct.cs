using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class VwProduct
    {
        public int Year { get; set; }
        public double Id { get; set; }
        public string Name { get; set; }
        public double? StroeId { get; set; }
        public string StoreName { get; set; }
        public double? BuyPrice { get; set; }
        public double? SalePrice { get; set; }
        public string Unit { get; set; }
        public double? Inventory { get; set; }
    }
}
