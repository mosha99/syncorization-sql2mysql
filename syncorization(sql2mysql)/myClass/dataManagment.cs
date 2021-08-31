using System.Collections.Generic;
using System.Linq;
using datamaster;

namespace DataEditor.myClass
{
    public interface IdataManagment
    {
        public IQueryable<VwProduct> getall();
        public  void test();

    }

    public class dataManagment:IdataManagment
    {
         MasterSET2008Context db = new MasterSET2008Context();
        public  IQueryable<VwProduct> getall()
        {
            IQueryable<VwProduct> list;
            var x = db.VwProducts.Count();
            list = db.VwProducts;

            return list;
        }

        public  void test() => db.SaveChanges();

    }
}