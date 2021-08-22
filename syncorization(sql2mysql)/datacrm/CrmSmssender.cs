using System;
using System.Collections.Generic;

#nullable disable

namespace data
{
    public partial class CrmSmssender
    {
        public int ShsId { get; set; }
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public string Tar { get; set; }
        public string Matn { get; set; }
        public int? Vaz { get; set; }
        public int? ShsIdFfo { get; set; }
        public string ShsIdFfoName { get; set; }

        public virtual CrmCustomer CrmCustomer { get; set; }
        public virtual SalMaly Shs { get; set; }
    }
}
