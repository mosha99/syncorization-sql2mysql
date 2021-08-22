using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Cal
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public double? CodAnb { get; set; }
        public string NameAnb { get; set; }
        public double? GhKh { get; set; }
        public double? GhFo { get; set; }
        public string Vah { get; set; }
        public double? Min { get; set; }
        public double? Max { get; set; }
        public double? MojAv { get; set; }
        public double? GhMojAv { get; set; }
        public double? Moj { get; set; }
        public string Tozih { get; set; }
        public double? TmpMoj { get; set; }
        public double? GhTmpMoj { get; set; }
        public string Vah2 { get; set; }
        public double? Zar { get; set; }
        public bool Selec { get; set; }
        public double? GhLastKh { get; set; }
        public double? GhMin { get; set; }
        public string TarAv { get; set; }
        public string Tafzil { get; set; }
        public bool Khad { get; set; }
        public double? MojZ { get; set; }
        public string Barcod { get; set; }
        public double? GhMas { get; set; }
        public string Shom { get; set; }
        public string Noecal { get; set; }
        public string TozihEng { get; set; }
        public short? RozS { get; set; }
        public double? GhlastFo { get; set; }
        public double? GhFok { get; set; }
        public double? GhFoj { get; set; }
        public double? HadTedffo { get; set; }
        public string Abad { get; set; }
        public string AbadAml { get; set; }
        public string AbadPish { get; set; }
        public string AbadHad { get; set; }
        public string Joz { get; set; }
        public double? Darvizitor { get; set; }
        public string AbadZar { get; set; }
        public double? Tedad { get; set; }
        public double? Hadfor { get; set; }
        public double? Shomareshi { get; set; }
        public double? MabNasbM { get; set; }
        public double? MabNasbS { get; set; }
        public bool? Garanti { get; set; }
        public string FfoNoe { get; set; }
        public double? GhRoz { get; set; }
        public double? Takh { get; set; }
        public double? TakhZar { get; set; }
        public double? Coupon { get; set; }
        public string NoeAnbar { get; set; }
        public double? CodHcT { get; set; }
        public double? CodHmT { get; set; }
        public string PartType { get; set; }
        public string PartSize { get; set; }
        public string Manufactory { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public double? Area { get; set; }
        public double? Weight { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
