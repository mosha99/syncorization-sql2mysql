using System;
using System.Collections.Generic;

#nullable disable

namespace data
{
    public partial class Sherkat
    {
        public Sherkat()
        {
            SalMalies = new HashSet<SalMaly>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SalMaly> SalMalies { get; set; }
    }
}
