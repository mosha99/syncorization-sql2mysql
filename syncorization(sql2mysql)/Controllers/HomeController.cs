using DataEditor.ErrorLog;
using DataEditor.Models;
using DataEditor.myClass;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using datamaster;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using PagedList;
using wooc_call;
using WooCommerceNET.WooCommerce.v2;

namespace Controllers
{

    public static class selectlist
    {
        public static List<VwProduct> list;

    }

    public class HomeController : Controller
    {

        public HomeController(IcrmManagment _Crm2008 ,IdataManagment _master2008)
        {
            Crm2008 = _Crm2008;
            master2008 = _master2008;
            TEditor = new TextEditor("App_Data/seting.txt");
            string seting = TEditor.Reader();
            seting st = JsonConvert.DeserializeObject<seting>(seting);
            Wocamers = new Woocall(st.urlServises,st.firstPass,st.secendPass);
        }

        protected IcrmManagment Crm2008 { set; get; }
        protected IdataManagment master2008 { set; get; }
        protected TextEditor TEditor { get; set; }
        protected Woocall Wocamers { get; set; }

        public ActionResult Index()
        {
            return View();
        }

        //[Authorize]
        public ActionResult seting()
        {
            seting myseting = new seting();
            try
            {
                string path3 = "App_Data/seting.txt";
                using (StreamReader JsonText = new StreamReader(path3, true))
                {

                    string Jsonstring = JsonText.ReadToEnd();
                    var serverSettings = JsonConvert.DeserializeObject<seting>(Jsonstring);
                    if (serverSettings != null)
                    {
                        myseting = serverSettings;
                    }
                    JsonText.Close();
                    //var x5 = JsonSerializer.Deserialize<seting>(x4);

                }
                ViewBag.testconection = null;
                return View(myseting);

            }
            catch (Exception ex)
            {
                errors.LogError(ex);

                return View(myseting);
            }



        }
        //[Authorize]
        [HttpPost]
        public ActionResult seting(seting myseting)
        {

            if (myseting.button == "save")
            {
                try
                {
                    string path3 = "App_Data/seting.txt";

                    using (StreamWriter JsonText = new StreamWriter(path3, false))
                    {
                        JsonText.Flush();
                        JsonText.Write("");
                        string json = JsonConvert.SerializeObject(myseting);
                        JsonText.Write(json);
                        JsonText.Close();
                    }

                    myseting.error = false;
                    ViewBag.succes = true;
                    return View(myseting);
                }
                catch (Exception ex)
                {
                    errors.LogError(ex);
                    myseting.error = true;
                    ViewBag.succes = false;
                    return View(myseting);
                }
            }
            else if (myseting.button == "test")
            {
                try
                {
                    bool succesM = testconection_Master(myseting);

                    bool succesC = testconection_Crm(myseting);

                    ViewBag.testconectionM = succesM.ToString();

                    ViewBag.testconectionC = succesC.ToString();

                    return View(myseting);
                }
                catch (Exception ex)
                {
                    errors.LogError(ex);
                    ViewBag.testconection = "false";
                    return View(myseting);
                }
            }
            return View(myseting);
        }
        //[Authorize]
        public ActionResult list(int? page, string store1, string example, string serch)
        {
            
            var x = Request;



            var list = master2008.getall();

            List<filtercs> storlist = new List<filtercs>();

            foreach (var item in list)
            {
                if (storlist.Where(d => d.stor_id == item.StroeId).Count() == 0)
                {
                    storlist.Add(new filtercs { name = item.StoreName, stor_id = item.StroeId });
                }
                else
                    if (item.StoreName != null || item.StoreName != "")
                {
                    if (storlist.Where(d => d.stor_id == item.StroeId).ToList()[0].name == null || storlist.Where(c => c.stor_id == item.StroeId).ToList()[0].name == "")
                    {
                        storlist.Where(c => c.stor_id == item.StroeId).ToList()[0].name = item.StoreName;
                    }
                }

            }

            if (store1 != null || example != null|| serch != null)
            {
                string store = store1;
                string Example = example;
                ViewBag.store1 = store;
                ViewBag.example = Example;
                ViewBag.serch = serch;

                if (store != "all") list = list.Where(s => s.StroeId.ToString() == store);
                if (Example == "on") list = list.Where(s => s.Inventory > 0);
                if (serch?.Trim() != null) list = list.Where(s => s.Name!=null && s.Name.Contains(serch));

            }
            //selectlist.list = null;
            //selectlist.list = list;

            List<commodity> vlist = new List<commodity>();

            IList<VwProduct> Ls = new List<VwProduct>();
            Ls = list.ToList();
            IPagedList<VwProduct> pList = Ls.ToPagedList(page ?? 1, 9);


            //IPagedList<VwProduct> pList = list.ToPagedList(page ?? 1, 9);
            ViewBag.store = storlist;
            return View(pList);
        }

        public bool testconection_Master(seting myseting)
        {
            seting myseting2 = new seting();
            string path3 = "App_Data/seting.txt";
            try
            {

                try
                {

                    using (StreamReader JsonText = new StreamReader(path3, true))
                    {
                        string Jsonstring = JsonText.ReadToEnd();
                        var serverSettings = JsonConvert.DeserializeObject<seting>(Jsonstring);
                        if (serverSettings != null)
                        {
                            myseting2 = serverSettings;

                        }
                        JsonText.Close();
                        //var x5 = JsonSerializer.Deserialize<seting>(x4);

                    }
                }
                catch (Exception)
                {
                    return false;
                }



                using (StreamWriter JsonText = new StreamWriter(path3, false))
                {
                    string json = JsonConvert.SerializeObject(myseting);
                    JsonText.Write(json);
                    JsonText.Close();
                }

                master2008.getall();

                using (StreamWriter JsonText = new StreamWriter(path3, false))
                {
                    string json = JsonConvert.SerializeObject(myseting2);
                    JsonText.Write(json);
                    JsonText.Close();
                }
                return true;

            }
            catch (Exception)
            {
                using (StreamWriter JsonText = new StreamWriter(path3, false))
                {
                    string json = JsonConvert.SerializeObject(myseting2);
                    JsonText.Write(json);
                    JsonText.Close();
                }
                return false;
            }

        }

        public bool testconection_Crm(seting myseting)
        {
            seting myseting2 = new seting();
            string path3 = "App_Data/seting.txt";
            try
            {

                try
                {

                    using (StreamReader JsonText = new StreamReader(path3, true))
                    {
                        string Jsonstring = JsonText.ReadToEnd();
                        var serverSettings = JsonConvert.DeserializeObject<seting>(Jsonstring);
                        if (serverSettings != null)
                        {
                            myseting2 = serverSettings;

                        }
                        JsonText.Close();
                        //var x5 = JsonSerializer.Deserialize<seting>(x4);

                    }
                }
                catch (Exception)
                {
                    return false;
                }



                using (StreamWriter JsonText = new StreamWriter(path3, false))
                {
                    string json = JsonConvert.SerializeObject(myseting);
                    JsonText.Write(json);
                    JsonText.Close();
                }

                Crm2008.get();

                using (StreamWriter JsonText = new StreamWriter(path3, false))
                {
                    string json = JsonConvert.SerializeObject(myseting2);
                    JsonText.Write(json);
                    JsonText.Close();
                }
                return true;

            }
            catch (Exception)
            {
                using (StreamWriter JsonText = new StreamWriter(path3, false))
                {
                    string json = JsonConvert.SerializeObject(myseting2);
                    JsonText.Write(json);
                    JsonText.Close();
                }
                return false;
            }

        }

        public ActionResult login(string ReturnUrl)
        {
            login log = new login();
            log.url = ReturnUrl;
            return View(log);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(login log, string ReturnUrl)
        {
            string url = ReturnUrl;
            if (log.password != "password")
            {
                ViewBag.error = "true";
                return View(log);
            }
            //FormsAuthentication.SetAuthCookie("admin", true);
            return Redirect(log.url);
        }

        public ActionResult logout()
        {
            if (User.Identity.IsAuthenticated != false)
            {
                //FormsAuthentication.SignOut();
            }
            return Redirect("index");
        }

        public ActionResult dbacsses()
        {

            return View();
        }
        //[Authorize]
        public ActionResult addCRM()
        {

            ViewBag.error = false;
            ViewBag.succes = false;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult addCRM(crm Crm)
        {
            bool f;
            if (ModelState.IsValid)
            {
                f = Crm2008.add(Crm);
            }
            else
            {
                f = false;
            }

            ViewBag.error = !f;
            ViewBag.succes = f;
            return View();
        }

        //[Authorize]
        public ActionResult serchCRM(int? page, string serch)
        {
            List<crm> list = new List<crm>();
            IPagedList Listc = null;

            ViewBag.succes = false;
            ViewBag.error = false;

            if (page == null)
            {
                ViewBag.page = 1;
            }
            else
            {
                ViewBag.page = page;
            }
            if (!string.IsNullOrEmpty(serch))
            {
                ViewBag.serch = serch;
            }

            List<crm> Lcrm = new List<crm>();
            if (string.IsNullOrEmpty(serch))
            {
                Lcrm = Crm2008.get();
            }
            else
            {
                Lcrm = Crm2008.get(serch);
            }
            Listc = Lcrm.ToPagedList(page ?? 1, 6);



            ViewBag.serch = serch;


            return View(Listc);
        }

        //[Authorize]
        public ActionResult deletCrm(int? page, int id, string serch)
        {
            bool succes = Crm2008.delete(id);
            ViewBag.succes = succes;
            ViewBag.error = !succes;
            if (!string.IsNullOrEmpty(serch))
            {
                ViewBag.serch = serch;
            }
            List<crm> Lcrm = new List<crm>();
            if (string.IsNullOrEmpty(serch))
            {
                Lcrm = Crm2008.get();
            }
            else
            {
                Lcrm = Crm2008.get(serch);
            }
            IPagedList<crm> listc;

            listc = Lcrm.ToPagedList(page ?? 1, 9);

            return RedirectToAction("serchCRM" ,new { serch= serch});
        }

    }
}
