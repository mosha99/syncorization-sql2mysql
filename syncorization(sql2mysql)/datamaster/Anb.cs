using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Anb
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public string NoeAnbar { get; set; }
        public string Adr { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
