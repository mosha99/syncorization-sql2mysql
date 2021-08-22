using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysFeildDataDictionary
    {
        public int Id { get; set; }
        public int IdTbSysTableDataDictionary { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }

        public virtual TbSysTableDataDictionary IdTbSysTableDataDictionaryNavigation { get; set; }
    }
}
