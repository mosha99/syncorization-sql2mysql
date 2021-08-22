using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysForm
    {
        public TbSysForm()
        {
            TbSysFormFeildDataDictionaries = new HashSet<TbSysFormFeildDataDictionary>();
            TbSysPackageForms = new HashSet<TbSysPackageForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FormName { get; set; }
        public int? IdTbSysTableDataDictionary { get; set; }
        public int? IdTbSysTableDataDictionary2 { get; set; }
        public string Crc { get; set; }

        public virtual ICollection<TbSysFormFeildDataDictionary> TbSysFormFeildDataDictionaries { get; set; }
        public virtual ICollection<TbSysPackageForm> TbSysPackageForms { get; set; }
    }
}
