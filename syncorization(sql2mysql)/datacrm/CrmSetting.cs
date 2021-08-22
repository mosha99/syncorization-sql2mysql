using System;
using System.Collections.Generic;

#nullable disable

namespace data
{
    public partial class CrmSetting
    {
        public int ShsId { get; set; }
        public string Takh { get; set; }
        public string MsgAdd { get; set; }
        public string MsgEdit { get; set; }
        public string MsgDel { get; set; }
        public string MsgAddFffo { get; set; }
        public string MsgAddMfo { get; set; }
        public double? Discount { get; set; }
        public string TypeDiscount { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LibKey { get; set; }
        public string Host { get; set; }
        public string MsgTavalod { get; set; }
        public string MsgEzdevaj { get; set; }
        public double? PersonelDiscount { get; set; }
        public string MsgOmoomi { get; set; }
        public string MsgOmoomi2 { get; set; }
        public int? FacRound { get; set; }
        public int ShsIdFfo { get; set; }
        public string FacTozihTavalod { get; set; }
        public double? DiscountTavalod { get; set; }
        public double? DiscountKasian { get; set; }
        public string FactozihKasian { get; set; }
        public string FacTozihEzdevaj { get; set; }
        public double? DiscountEzdevaj { get; set; }
        public string FacTozih { get; set; }
        public string FacTozihPersonelDiscount { get; set; }
        public string TerminalId { get; set; }
        public string MerchNumber { get; set; }
        public string Terminalpass { get; set; }
        public string TerminalDelpass { get; set; }
        public string Smstype { get; set; }
        public string Msgffo1 { get; set; }
        public string Msgffo2 { get; set; }
        public string Msgffo3 { get; set; }
        public string Msgffo4 { get; set; }
        public string Msgffo5 { get; set; }
        public string TerminalId2 { get; set; }
        public string TerminalUser { get; set; }
        public string MerchNumber2 { get; set; }
        public string Terminalpass2 { get; set; }
        public string TerminalDelpass2 { get; set; }
        public string TerminalUser2 { get; set; }
        public double? KasianCodHc { get; set; }
        public double? KasianCodHmE { get; set; }
        public double? KasianCodHmB { get; set; }
        public double? KasianCodHmM { get; set; }
        public double? KasianCodHmM2 { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
