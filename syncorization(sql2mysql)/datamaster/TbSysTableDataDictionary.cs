using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysTableDataDictionary
    {
        public TbSysTableDataDictionary()
        {
            TbSysFeildDataDictionaries = new HashSet<TbSysFeildDataDictionary>();
            TbSysFormFeildDataDictionaries = new HashSet<TbSysFormFeildDataDictionary>();
        }

        public int Id { get; set; }
        public int Root { get; set; }
        public string Name { get; set; }
        public string Crc { get; set; }

        public virtual ICollection<TbSysFeildDataDictionary> TbSysFeildDataDictionaries { get; set; }
        public virtual ICollection<TbSysFormFeildDataDictionary> TbSysFormFeildDataDictionaries { get; set; }
    }
}
