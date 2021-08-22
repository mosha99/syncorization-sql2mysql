using System;
using System.Collections.Generic;

#nullable disable

namespace data
{
    public partial class CrmCompany
    {
        public int ShsId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Delegate { get; set; }
        public string Tozih { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
