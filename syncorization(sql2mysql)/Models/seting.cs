using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataEditor.Models
{
    public class seting:Iseting
    {
        public string DbName { set; get; }
        public string DbName1 { set; get; }
        public string DbSuorse { set; get; }
        public string SqlUsername { set; get; }
        public string SqlPassword { set; get; }
        public int FiscalYear { set; get; }
        public string urlServises { set; get; }
        public string button { set; get; }
        public bool error { set; get; }
    }
}