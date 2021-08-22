using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class UserDatum
    {
        public int ShsId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Kind { get; set; }
        public string GridData { get; set; }
        public string Date { get; set; }
        public string LockSerial { get; set; }
        public string Permission { get; set; }
        public string Crc { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
