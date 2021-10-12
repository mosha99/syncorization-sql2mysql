using Controllers;
using datamaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wooc_call;
using WooCommerceNET.WooCommerce.v2;

namespace myClass
{
    public class WooSet
    {
        public WooSet(Woocall _woc)
        {
            woc = _woc;
        }
        protected Woocall woc;

        public async Task<Product> Get(int sku)
        {
            Dictionary<string, string> directory = new Dictionary<string, string>();
            directory.Add("sku", sku.ToString());
            List<Product> finded = await woc.Get(directory);
            if (finded == null || finded.Count() == 0) throw new Exception("کالا پیدا نشد");
            return finded.FirstOrDefault();
        }

        public async Task OneSet(int sku, Product product)
        {
            Dictionary<string, string> directory = new Dictionary<string, string>();
            directory.Add("sku", sku.ToString());
            List<Product> finded = await woc.Get(directory);
            if (finded == null || finded.Count() == 0) throw new Exception("کالا پیدا نشد");
            uint? id = finded.FirstOrDefault().id;
            await woc.Update(id, product);
        }

        public async Task AllSet(IQueryable<VwProduct> Datalist, List<int> filter)
        {
            double percent = Datalist.Count();
            if (percent != 0) percent = 75 / percent;

            if (filter.Count() == 0)
            {
                progses.persent = 100;
                return;
            }
            List<Product> sendable = new List<Product>();
            List<Product> Buyable = new List<Product>();

            List<Product> finalset = new List<Product>();
            List<Product> UnBuyable = new List<Product>();

            int g = 1;
            int pagecount = 64;
            progses.persent = 0;

            List<double> ErrorL = new List<double>();


            foreach (VwProduct item in Datalist)
            {
                try
                {
                    Dictionary<string, string> d = new Dictionary<string, string>();
                    d.Add("sku", item.Id.ToString());
                    List<Product> k = await woc.Get(d);
                    progses.persent += percent;
                    if (k!=null && k.Count() != 0)
                    finalset.AddRange(k);
                }
                catch (Exception ex)
                {
                    double gh =item.Id;
                    ErrorL.Add(gh);
                }

            }

            //var x1 = finalset.Where(x => x.id == 135);
            //ErrorL=ErrorL.ToList();

            /*
            for (int i = 1; i < 10000000; i++)
            {

                Dictionary<string, string> directory = new Dictionary<string, string>();

                directory.Add("per_page", pagecount.ToString());
                directory.Add("page", i.ToString());
                try
                {
                    var y = await woc.Get(directory);
                    if (y.ToList().Count()==0)
                    {
                        throw new Exception();
                    }
                    ft.AddRange(y.ToList());
                    UnBuyable.AddRange(y.Where(x => string.IsNullOrWhiteSpace(x.sku)).ToList());
                    Buyable.AddRange(y.Where(x => !string.IsNullOrWhiteSpace(x.sku)).ToList());
                    progses.persent += 4;
                    Console.WriteLine("e1");
                }
                catch (Exception)
                {
                    if (pagecount == 1) break;
                    i = ((i -1)* 2);
                    pagecount /= 2;
                    if (pagecount == 1)
                        pagecount = 1;
                }

            }
            */

            /*ft = ft.OrderBy(x => x.id).ToList();
            ft.ForEach(x => Console.WriteLine(x.id));*/

            /**/

            /* foreach (var item in Buyable)
             {
                 if (filter.FirstOrDefault(x => x.ToString() == item.sku.ToString()) != 0)
                 {
                     finalset.Add(item);
                 }
             }*/




            UnBuyable.ForEach(i => i.stock_quantity = 0);

            foreach (var i in finalset)
            {
                i.in_stock = true;
                i.stock_quantity = Convert.ToInt32(Datalist.FirstOrDefault(x => x.Id.ToString() == i.sku.ToString())?.Inventory == null ? 0 : Datalist.FirstOrDefault(x => x.Id.ToString() == i.sku.ToString())?.Inventory);
                i.sale_price = Convert.ToDecimal(Datalist.FirstOrDefault(x => x.Id.ToString() == i.sku.ToString())?.SalePrice2 == null ? 0 : Datalist.FirstOrDefault(x => x.Id.ToString() == i.sku.ToString())?.SalePrice2);
                i.regular_price = Convert.ToDecimal(i.sale_price == null ? 0 : i.sale_price);
            }

            foreach (var i in UnBuyable)
            {
                i.in_stock = false;
            }

            finalset.AddRange(UnBuyable);

            double m = 100 - progses.persent;
            int coupdate = (finalset.Count() / 50) + 1;

            m = m / coupdate;
            while (finalset.Count() > 50)
            {
                progses.persent += m;
                sendable = finalset.Take(50)?.ToList();
                finalset.RemoveRange(0, 50);
                await woc.UpdateRange(sendable);
            }
            progses.persent += m;
            await woc.UpdateRange(finalset);
            progses.persent = 100;
        }
    }
}
