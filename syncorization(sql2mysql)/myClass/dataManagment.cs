using System.Collections.Generic;
using System.Linq;
using DataEditor.Models;
using datamaster;

namespace DataEditor.myClass
{
    public interface IdataManagment
    {
        public IQueryable<VwProduct> getall();
        public void test();
        public List<FilterYear> GetYearCode();
    }

    public class years
    {
        public int year { set; get; }
        public int code { set; get; }
    }
    public class dataManagment : IdataManagment
    {
        MasterSET2008Context db = new MasterSET2008Context();
        public IQueryable<VwProduct> getall()
        {
            IQueryable<VwProduct> list;
            var x = db.VwProducts.Count();
            list = db.VwProducts;

            return list;
        }

        public void test() => db.SaveChanges();

        public List<FilterYear> GetYearCode()
        {
            List<VwCompany> List = db.VwCompanies.ToList();
            List<FilterYear> li = new List<FilterYear>();
            foreach (VwCompany item in List)
            {
                li.Add(new FilterYear() {Name=item.Company +" : "+item.YearName, num=item.Year });
            }
            return li;
        }

    }

}