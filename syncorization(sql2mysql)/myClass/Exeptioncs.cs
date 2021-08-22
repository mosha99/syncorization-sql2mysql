using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataEditor.myClass
{
    public class Exeptioncs:Exception
    {
        public Exeptioncs()
        {

        }

        public Exeptioncs(string attr,string value): base(String.Format("Invalid value {0} for attribiot{1}",attr, value)) 
        {

        }
    }
}