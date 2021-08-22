using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataEditor.Models
{
    public class commodity
    {
        public int Id_Year { get; set; }
        public double id { get; set; }
        public string NAME { get; set; }
        public Nullable<double> id_store { get; set; }
        public string name_store { get; set; }
        public Nullable<double> BuyPrice { get; set; }
        public Nullable<double> SalePrice { get; set; }
        public string UintName { get; set; }

    }
}