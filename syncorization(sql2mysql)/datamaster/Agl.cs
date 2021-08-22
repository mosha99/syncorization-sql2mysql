using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Agl
    {
        public int ShsId { get; set; }
        public string NoeF { get; set; }
        public double Cod { get; set; }
        public double Rad { get; set; }
        public double? CodAnb { get; set; }
        public string NameAnb { get; set; }
        public double? CodC { get; set; }
        public string NameC { get; set; }
        public double? MojC { get; set; }
        public double? TedC { get; set; }
        public string VahC { get; set; }
        public double? ZarC { get; set; }
        public double? GhZar { get; set; }
        public double? ZarCol { get; set; }
        public double? GhTak { get; set; }
        public double? GhCol { get; set; }
        public double? GhNa { get; set; }
        public string TimeC { get; set; }
        public string TarC { get; set; }
        public string TozihC { get; set; }
        public double? TakhC { get; set; }
        public double? TakhTedC { get; set; }
        public double? GhMin { get; set; }
        public double? MojFifo { get; set; }
        public double? MojLifo { get; set; }
        public double? CodHc { get; set; }
        public double? CodHm { get; set; }
        public string Vah2C { get; set; }
        public string Shom { get; set; }
        public string NoeTakh { get; set; }
        public double? MojZ { get; set; }
        public string BarcodC { get; set; }
        public double? GhMasC { get; set; }
        public string TarS { get; set; }
        public string AbadC { get; set; }
        public string Ranandeh { get; set; }
        public string Tozih2C { get; set; }
        public string Noecal { get; set; }
        public string TozihEng { get; set; }
        public double? CodProj { get; set; }
        public double? CodShobe { get; set; }
        public double? Haz { get; set; }
        public double? GhMinhaz { get; set; }
        public double? CodFpa { get; set; }
        public double? CodAnb2 { get; set; }
        public string NameAnb2 { get; set; }
        public string Tafzil { get; set; }
        public bool? Guaranty { get; set; }
        public double? CodHcVi { get; set; }
        public double? CodHmVi { get; set; }
        public double? CodHcT { get; set; }
        public double? CodHmT { get; set; }
        public double? Shg1 { get; set; }
        public double? Shg2 { get; set; }
        public string TarTo { get; set; }
        public double? Exchange2 { get; set; }
        public string Acronym2 { get; set; }
        public double? GhNa2 { get; set; }
        public double? Exchange3 { get; set; }
        public string Acronym3 { get; set; }
        public double? GhNa3 { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
