using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace data
{
    public partial class CrmCustomer
    {
        public CrmCustomer()
        {
            CrmLogs = new HashSet<CrmLog>();
            CrmSmssenders = new HashSet<CrmSmssender>();
        }

        public int ShsId { get; set; }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sho { get; set; }
        public string Mobil { get; set; }
        public string Adr { get; set; }
        public string Fax { get; set; }
        public string Tozih { get; set; }
        public string CodEshterak { get; set; }
        public string CodeMelli { get; set; }
        public bool? SendSms { get; set; }
        public string TarTavalod { get; set; }
        public string City { get; set; }
        public string Pas { get; set; }
        public string TarEz { get; set; }
        public string Mail { get; set; }
        public string Job { get; set; }
        public int? IdCompany { get; set; }
        public string CartKind { get; set; }
        public int MosId { get; set; }
        public bool? Lottery { get; set; }
        public string Adder { get; set; }
        public string Editor { get; set; }
        public string TarS { get; set; }
        public string Father { get; set; }
        public string Scode { get; set; }
        public string Homephone { get; set; }
        public string Namel { get; set; }
        public string Sstndrdcode { get; set; }
        public string Sodor { get; set; }
        public int? Sex { get; set; }
        public int? Tahol { get; set; }
        public string Homecode { get; set; }
        public string Workcode { get; set; }
        public string Workaddr { get; set; }
        public string Workphone { get; set; }
        public string Bincart { get; set; }
        public string BinExpdate { get; set; }
        public string BinCvv2 { get; set; }
        public string TarEdit { get; set; }
        public string TarKasianD { get; set; }
        public string TarKasianT { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual SalMaly Shs { get; set; }
        public virtual ICollection<CrmLog> CrmLogs { get; set; }
        public virtual ICollection<CrmSmssender> CrmSmssenders { get; set; }
    }
}
