﻿using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Sa0
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Tar { get; set; }
        public double? Mab { get; set; }
        public string Noe { get; set; }
        public bool Gat { get; set; }
        public string Moz { get; set; }
        public string Adder { get; set; }
        public string Editor { get; set; }
        public int? Payvast { get; set; }
        public int? EditCount { get; set; }
        public double? CodSabet { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
