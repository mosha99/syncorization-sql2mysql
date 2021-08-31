using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class VwCustomer
    {
        public int Year { get; set; }
        public double Id { get; set; }
        public string Name { get; set; }
        public double? BookId { get; set; }
        public double? AccountId { get; set; }
        public string Adress { get; set; }
        public string Tel { get; set; }
        public string Mobil { get; set; }
    }
}
