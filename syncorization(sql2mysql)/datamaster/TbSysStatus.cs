using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysStatus
    {
        public int ShsId { get; set; }
        public string TbName { get; set; }
        public string FiName { get; set; }
        public int Value { get; set; }
        public int Root { get; set; }
        public string DisplayLabel { get; set; }
        public string GroupName { get; set; }
        public string Text { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
