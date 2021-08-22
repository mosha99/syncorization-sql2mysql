using System.Collections.Generic;
using System.Linq;
using datamaster;

namespace DataEditor.myClass
{
    public static class dataManagment
    {
       static MasterSET2008Context db = new MasterSET2008Context();
        public static IQueryable<VwProduct> getall()
        {
            IQueryable<VwProduct> list = db.VwProducts;
            return list;
        }
    }
}