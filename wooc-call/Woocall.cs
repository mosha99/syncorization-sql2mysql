using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WooCommerceNET;
using WooCommerceNET.WooCommerce.v2;
using WooCommerceNET.WooCommerce.v2.Extension;
namespace wooc_call
{
    public class Woocall
    {
        public Woocall(string Url, string pass1, string pass2)
        {
            woc = new WCObject(new RestAPI(Url, pass1, pass2));
        }

        protected WCObject woc { set; get; }

        public async Task<Product> Get(int id)
        {
            try
            {
                Product product = await woc.Product.Get(id);
                return product;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<List<Product>> Get(Dictionary<string, string> directory)
        {
            try
            {
                List<Product> products = await woc.Product.GetAll(directory);
                return products;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<bool> Update(uint? id, Product product)
        {
            try
            {
                int Id =Convert.ToInt32(id);
                await woc.Product.Update(Id, product);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> UpdateRange(List<Product> products)
        {
            try
            {
                ProductBatch bt = new ProductBatch();
                bt.update= products;
                await woc.Product.UpdateRange(bt);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delet(int id)
        {
            try
            {
                await woc.Product.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
