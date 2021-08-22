using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Yad
    {
        public int ShsId { get; set; }
        public string Tar { get; set; }
        public int Rad { get; set; }
        public string Yadasht { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
