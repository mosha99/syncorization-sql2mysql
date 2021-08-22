using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysGroup
    {
        public TbSysGroup()
        {
            TbSysPackageForms = new HashSet<TbSysPackageForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Crc { get; set; }

        public virtual ICollection<TbSysPackageForm> TbSysPackageForms { get; set; }
    }
}
