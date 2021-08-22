using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysCurrency
    {
        public int ShsId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Exchange { get; set; }
        public string Acronym { get; set; }
        public string FormatDisplay { get; set; }
        public string LastUpdate { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
