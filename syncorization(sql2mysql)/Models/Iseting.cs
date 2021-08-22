using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEditor.Models
{
    public interface Iseting
    {
         string SqlUsername { set; get; }
         string SqlPassword { set; get; }
         int FiscalYear { set; get; }
         string urlServises { set; get; }
    }
}
