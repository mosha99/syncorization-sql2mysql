using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysPackage
    {
        public TbSysPackage()
        {
            TbSysPackageForms = new HashSet<TbSysPackageForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string Crc { get; set; }

        public virtual ICollection<TbSysPackageForm> TbSysPackageForms { get; set; }
    }
}
