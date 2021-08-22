using System;
using System.Collections.Generic;

#nullable disable

namespace data
{
    public partial class Karbar
    {
        public int ShsId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pas { get; set; }
        public bool? TsCrmCustomer { get; set; }
        public bool? BaddCrmCustomer { get; set; }
        public bool? BeditCrmCustomer { get; set; }
        public bool? BdelCrmCustomer { get; set; }
        public bool? TsrepCrmCustomer { get; set; }
        public bool? TsCrmCompany { get; set; }
        public bool? BaddCrmCompany { get; set; }
        public bool? BeditCrmCompany { get; set; }
        public bool? BdelCrmCompany { get; set; }
        public bool? TsrepCrmCompany { get; set; }
        public bool? TsCrmAgreement { get; set; }
        public bool? BaddCrmAgreement { get; set; }
        public bool? BeditCrmAgreement { get; set; }
        public bool? BdelCrmAgreement { get; set; }
        public bool? TsrepCrmAgreement { get; set; }
        public bool? TsCrmDiscount { get; set; }
        public bool? BaddCrmDiscount { get; set; }
        public bool? BeditCrmDiscount { get; set; }
        public bool? BdelCrmDiscount { get; set; }
        public bool? TsrepCrmDiscount { get; set; }
        public bool? BdelCrmLog { get; set; }
        public bool? TsrepCrmLog { get; set; }
        public bool? TsCrmSetting { get; set; }
        public bool? BeditCrmSetting { get; set; }
        public bool? TsCrmSmssender { get; set; }
        public bool? BaddCrmSmssender { get; set; }
        public bool? BeditCrmSmssender { get; set; }
        public bool? BdelCrmSmssender { get; set; }
        public bool? Tskarbar { get; set; }
        public bool? Admin { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
