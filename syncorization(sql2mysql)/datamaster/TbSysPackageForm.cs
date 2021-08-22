using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class TbSysPackageForm
    {
        public int IdTbSysPackage { get; set; }
        public int IdTbSysGroup { get; set; }
        public int IdTbSysForm { get; set; }

        public virtual TbSysForm IdTbSysFormNavigation { get; set; }
        public virtual TbSysGroup IdTbSysGroupNavigation { get; set; }
        public virtual TbSysPackage IdTbSysPackageNavigation { get; set; }
    }
}
