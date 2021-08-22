using System;
using System.Collections.Generic;

#nullable disable

namespace datamaster
{
    public partial class Karkfor
    {
        public int ShsId { get; set; }
        public double Cod { get; set; }
        public string Name { get; set; }
        public string MMah { get; set; }
        public string NRoz { get; set; }
        public string MRoz { get; set; }
        public string NEza { get; set; }
        public string MEza { get; set; }
        public string NTat { get; set; }
        public string MTat { get; set; }
        public string MFog { get; set; }
        public string MAel { get; set; }
        public string MBah { get; set; }
        public string MKha { get; set; }
        public string MMsk { get; set; }
        public string MJaz { get; set; }
        public string MMas { get; set; }
        public string MSak { get; set; }
        public string MBD { get; set; }
        public string MBO { get; set; }
        public string MM { get; set; }
        public string MKTozih { get; set; }
        public string MK { get; set; }
        public string MDTozih { get; set; }
        public string MD { get; set; }
        public string JamK { get; set; }
        public string JamD { get; set; }
        public string Tozih { get; set; }
        public string M01a { get; set; }
        public string M02a { get; set; }
        public string M03a { get; set; }
        public string M04a { get; set; }
        public string M05a { get; set; }
        public string M06a { get; set; }
        public string M07a { get; set; }
        public string M01k { get; set; }
        public string M02k { get; set; }
        public string MBDK { get; set; }

        public virtual SalMaly Shs { get; set; }
    }
}
