using System;
using System.Collections.Generic;

#nullable disable

namespace data
{
    public partial class SalMaly
    {
        public SalMaly()
        {
            CrmAgreements = new HashSet<CrmAgreement>();
            CrmCompanies = new HashSet<CrmCompany>();
            CrmCustomers = new HashSet<CrmCustomer>();
            CrmLogs = new HashSet<CrmLog>();
            CrmSmssenders = new HashSet<CrmSmssender>();
            Karbars = new HashSet<Karbar>();
        }

        public int ShsId { get; set; }
        public int Root { get; set; }
        public int Sal { get; set; }

        public virtual Sherkat RootNavigation { get; set; }
        public virtual CrmSetting CrmSetting { get; set; }
        public virtual ICollection<CrmAgreement> CrmAgreements { get; set; }
        public virtual ICollection<CrmCompany> CrmCompanies { get; set; }
        public virtual ICollection<CrmCustomer> CrmCustomers { get; set; }
        public virtual ICollection<CrmLog> CrmLogs { get; set; }
        public virtual ICollection<CrmSmssender> CrmSmssenders { get; set; }
        public virtual ICollection<Karbar> Karbars { get; set; }
    }
}
