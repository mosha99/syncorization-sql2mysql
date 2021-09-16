﻿using System;
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

        public async Task<List<Product>> Get()
        {
            try
            {
                List<Product> products = await woc.Product.GetAll();
                return products;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<bool> Update(int id, Product product)
        {
            try
            {
                await woc.Product.Update(id, product);
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
                await woc.Product.UpdateRange(new WooCommerceNET.Base.BatchObject<Product> { update= products});
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
