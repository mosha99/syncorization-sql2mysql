using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysFormFeildDataDictionary
    {
        public int Id { get; set; }
        public int? IdTbSysFeildDataDictionary { get; set; }
        public int? IdTbSysForm { get; set; }
        public string FarsiLabel { get; set; }

        public virtual TbSysTableDataDictionary IdTbSysFeildDataDictionaryNavigation { get; set; }
        public virtual TbSysForm IdTbSysFormNavigation { get; set; }
    }
}
