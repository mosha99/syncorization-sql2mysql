using datamaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wooc_call;
using WooCommerceNET.WooCommerce.v2;

namespace syncorization_sql2mysql_.myClass
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

        public async Task AllSet(int sku, IQueryable<VwProduct> Datalist)
        {

            List<Product> Buyable = new List<Product>();
            List<Product> UnBuyable = new List<Product>();

            int g = 1;
            int pagecount = 64;
            for (int i = 1; i < 10000000; i++)
            {

                Dictionary<string, string> directory = new Dictionary<string, string>();
                Console.WriteLine("|||||||||||||||||||||||");

                directory.Add("per_page", pagecount.ToString());
                directory.Add("page", i.ToString());
                try
                {
                    var x = await woc.Get(directory);
                    UnBuyable = x.Where(x => x.sku == null).ToList();
                    Buyable = x.Where(x => x.sku != null).ToList();

                }
                catch (Exception)
                {
                    if (pagecount == 1) break;
                    i = (i - 1) * 2;
                    pagecount /= 2;
                }

            }
            foreach (Product item in Buyable)
            {
                if (Datalist.FirstOrDefault(x => x.Id.ToString() == item.sku.ToString()) == null)
                    Buyable.Remove(item);
            }
            UnBuyable.ForEach(i => i.on_sale = false);
            await woc.UpdateRange(UnBuyable);
        }
    }
}
