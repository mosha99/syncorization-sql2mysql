using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace datamaster
{
    public class Iproduct
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
