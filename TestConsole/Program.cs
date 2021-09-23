using System;
using wooc_call;
using System.Text.Json;
using System.Text;
using System.Collections.Generic;
using WooCommerceNET.WooCommerce.v2;
using TestConsole.datamaster;
using System.Linq;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace TestConsole
{
    public class dataManagment
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

    }

    class pr
    {
        public string nameinDatabae { set; get; }
        public string idinDatabase { set; get; }
        public string sku { set; get; }
        public string nameinwoocamerc { set; get; }
        public string idinwoocamerc { set; get; }

    }

    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {

                Woocall W = new Woocall("http://poyanmehrzarin.ir/wp-json/wc/v2/", "ck_0efc32643696debf08dfe38811d70a0902a07036", "cs_86874c8559e0b47e85c2edf784a6c43522e24514");
                dataManagment data = new dataManagment();
                TextEditor gh = new TextEditor("jsonlistproduct.txt");
                IQueryable<VwProduct> ps = data.getall();

                Dictionary<string, string> directory = new Dictionary<string, string>();
                /*directory.Add("sku", "3645606");
                var x = await W.Get(directory);
                var y = x;*/

                await AllSet(ps, W);

                /*
                int g = 1;
                int pagecount = 64;

                List<pr> lp = new List<pr>();
                for (int i = 1; i < 10000000; i++)
                {

                    Dictionary<string, string> directory = new Dictionary<string, string>();
                    Console.WriteLine("|||||||||||||||||||||||");

                    directory.Add("per_page", pagecount.ToString());
                    directory.Add("page", i.ToString());
                    try
                    {

                        var x = await W.Get(directory);
                        var y = x;
                        foreach (var item in y)
                        {
                            lp.Add(new pr { nameinwoocamerc = item.name, idinwoocamerc = item.id.ToString(), sku = item.sku });
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("--------------------------");
                        if (pagecount == 1) break;
                        i = (i - 1) * 2;
                        pagecount /= 2;
                    }

                }

                Console.WriteLine("******************************************End***************************************************");
                int notf = 0, f = 0;
                foreach (var item in lp)
                {
                    var x = data.getall();
                    VwProduct output = null;
                    output = x.FirstOrDefault(x => x.Id.ToString() == item.sku);
                    if (output != null)
                    {
                        item.nameinDatabae = output.Name;
                        item.idinDatabase = output.Id.ToString();
                        f++;
                    }
                    else
                    {
                        notf++;
                    }

                }

                Console.WriteLine(f + " found");
                Console.WriteLine(notf + " not found");

                foreach (var item in lp)
                {
                    var x = data.getall();
                    VwProduct output = null;
                    output = x.FirstOrDefault(x => x.Id.ToString() == item.sku);
                    if (output == null)
                    {


                        notf++;
                    }
                    else
                    {
                        gh.append(Environment.NewLine);
                        gh.append("DbName :" + output.Name);
                        gh.append(Environment.NewLine);
                        gh.append("WCName :" + item.nameinwoocamerc);
                        gh.append(Environment.NewLine);

                        gh.append("sku :" + item.sku);
                        gh.append(Environment.NewLine);

                        gh.append("Dbid :" + output.Id);
                        gh.append(Environment.NewLine);

                        gh.append("WCid :" + item.idinwoocamerc);
                        gh.append(Environment.NewLine);

                        gh.append("*****************************");
                        f++;
                    }

                }
                List<pr> accounts = lp.OrderByDescending(x => x.idinDatabase).ToList();
                string filePath = @"C:\Users\mosha\Documents\Book1.xlsx";

                exel(accounts, filePath);


                Console.ReadLine();*/

            }
            catch (Exception ex)
            {

                throw;
            }

        }


        public static async Task AllSet(IQueryable<VwProduct> Datalist, Woocall woc)
        {
            List<Product> All = new List<Product>();
            List<Product> Buyable = new List<Product>();
            List<Product> UnBuyable = new List<Product>();

            int g = 1;
            int pagecount = 64;
            for (int i = 1; i < 10000000; i++)
            {

                Dictionary<string, string> directory = new Dictionary<string, string>();
                directory.Add("per_page", pagecount.ToString());
                directory.Add("page", i.ToString());
                try
                {
                    var x = await woc.Get(directory);
                    UnBuyable.AddRange(x.Where(x => string.IsNullOrWhiteSpace(x.sku)).ToList());
                    Buyable.AddRange(x.Where(x => !string.IsNullOrWhiteSpace(x.sku)).ToList());

                }
                catch (Exception)
                {
                    if (pagecount == 1) break;
                    i = (i - 1) * 2;
                    pagecount /= 2;
                }

            }
            /*foreach (Product item in Buyable)
            {
                if (Datalist.FirstOrDefault(x => x.Id.ToString() == item.sku.ToString()) == null)
                    Buyable.Remove(item);
            }*/
            UnBuyable.ForEach(i => i.in_stock = false);
            await woc.UpdateRange(UnBuyable);
        }


        public static void exel(List<pr> accounts, string filePath)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                //open workbook
                Excel.Workbook workbook = xlApp.Workbooks.Open(filePath);
                //open sheet
                Excel._Worksheet sheet = workbook.Sheets[1] as Excel._Worksheet;
                Excel.Range excelFile = sheet.UsedRange;

                excelFile.Cells[1, "A"] = "نام وکامرسی";
                excelFile.Cells[1, "B"] = "شناسه وکامرس";
                excelFile.Cells[1, "C"] = "آیدی واسط";
                excelFile.Cells[1, "D"] = "نام در دیتابیس";
                excelFile.Cells[1, "E"] = "شناسه دیتابیس";

                for (int i = 0; i < accounts.Count(); i++)
                {
                    excelFile.Cells[i + 2, "A"] = accounts[i].nameinwoocamerc;
                    excelFile.Cells[i + 2, "B"] = accounts[i].idinwoocamerc;
                    excelFile.Cells[i + 2, "C"] = accounts[i].sku;
                    excelFile.Cells[i + 2, "D"] = accounts[i].nameinDatabae;
                    excelFile.Cells[i + 2, "E"] = accounts[i].idinDatabase;
                }
                //save changed data in second excel file
                workbook.Save();

                GC.Collect();
                GC.WaitForPendingFinalizers();
                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(excelFile);
                //close and release
                workbook.Close();
                Marshal.ReleaseComObject(workbook);
                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);


            }
            catch (Exception ex) { throw; }


        }
    }
}

