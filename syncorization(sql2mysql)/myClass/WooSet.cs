using Controllers;
using DataEditor.myClass;
using datamaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wooc_call;
using System.Threading;
using WooCommerceNET.WooCommerce.v2;

namespace myClass
{
    public class wh
    {
        public string sku { set; get; }
        public int id { set; get; }
    }
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

        public async Task AllSet(IQueryable<VwProduct> Datalist, List<int> filter, string a)
        {

            List<Product> sendable = new List<Product>();

            List<Product> finalset = new List<Product>();

            List<Product> Buyable = new List<Product>();


            for (int i = 0; i < 10000; i++)
            {

                Dictionary<string, string> directory = new Dictionary<string, string>();

                //directory.Add("context", "edit");
                directory.Add("per_page", "30");
                directory.Add("page", i.ToString());

                try
                {

                    var y = await woc.Get(directory);
                    Buyable.AddRange(y.ToList());
                    if (y.Count() == 0) break;
                    progses.persent += 50.0 / 20;

                }
                catch (Exception ex)
                {

                }

            }

            var ff = Buyable.Where(x => x.sku == "135" || x.sku == "357");
            try
            {
                foreach (var g in filter)
                {
                    Product i = new Product();
                    uint? id = Buyable.FirstOrDefault(x => x.sku == g.ToString())?.id;
                    if (id == null) continue;
                    i.id = id;

                    var prod = Datalist.FirstOrDefault(x => x.Id.ToString() == g.ToString());


                    var t = prod.SalePrice2;

                    /* (prod.Inventory <= 0) { i.in_stock = false; }
                    else
                    {
                        i.in_stock = true;
                    }*/

                    Console.WriteLine($"prodouct id : {id} sku : {g}  price : {t}  yer : {prod.Year} updated");


                    if (a == "b")
                    {
                        if (prod.Inventory <= 0)
                        {
                            t = 0;
                            prod.Inventory = 0;
                        }

                        i.stock_quantity = Convert.ToInt32(prod.Inventory);
                        i.manage_stock = true;
                    }
                    else
                    {
                        //i.stock_quantity = null

                        if (prod.Inventory <= 0)
                        {
                            i.in_stock = false;
                            t = 0;
                        }
                        else
                        {
                            i.in_stock = true;
                        }
                        i.manage_stock = false;
                    }

                    i.backorders = "no";

                    i.sale_price = Convert.ToDecimal(t);

                    i.regular_price = Convert.ToDecimal(i.sale_price == null ? 0 : i.sale_price);

                    finalset.Add(i);
                }


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
            catch (Exception ex)
            {
            }
        }
    }
}
