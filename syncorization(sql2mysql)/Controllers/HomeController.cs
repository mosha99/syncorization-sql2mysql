using DataEditor.ErrorLog;
using DataEditor.Models;
using DataEditor.myClass;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
//using datamaster;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using PagedList;

namespace Controllers
{
    /*
    public static class selectlist
    {
        public static List<VwProduct> list;

    }
    public static class query
    {
        private static IPagedList<crm> list;

        private static string serch;

        private static bool succes;
         
        public static void set(IPagedList<crm> input, string _serch, bool _succes)
        {
            serch = _serch;
            succes = _succes;
            list = input;
        }
        public static IPagedList<crm> get()
        {
            return list;
        }
        public static bool getb()
        {
            return succes;
        }
        public static string gets()
        {
            return serch;
        }

    }
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult seting()
        {
            seting myseting = new seting();
            try
            {
                string path3 = "~/App_Data/seting.txt";
                using (StreamReader JsonText = new StreamReader(path3, true))
                {

                    string Jsonstring = JsonText.ReadToEnd();
                    var serverSettings = JsonConvert.DeserializeObject<seting>(Jsonstring,
                    new JsonSerializerSettings());
                    myseting.SqlUsername = serverSettings.SqlUsername;
                    myseting.SqlPassword = serverSettings.SqlPassword;
                    myseting.urlServises = serverSettings.urlServises;
                    myseting.FiscalYear = serverSettings.FiscalYear;
                    //var x5 = JsonSerializer.Deserialize<seting>(x4);

                }
                ViewBag.testconection = null;
                return View(myseting);

            }
            catch (Exception ex)
            {
                //errors.

                return View(myseting);
            }



        }
        [Authorize]
        [HttpPost]
        public ActionResult seting(seting myseting)
        {

            if (myseting.button == "save")
            {


                try
                {
                    string path3 = "~/App_Data/seting.txt";
                    FileStream file = new FileStream(path3, FileMode.Open);
                    System.IO.File.Delete(path3);
                    var s = System.IO.File.Exists(path3);
                    System.IO.File.CreateText(path3);
                    using (StreamWriter writer = new StreamWriter(path3, true))
                    {
                        FileStream fileStream = new FileStream(path3, FileMode.Open, FileAccess.Write);
                        writer.Write("");
                        string json = JsonConvert.SerializeObject(myseting);
                        writer.Write(json);
                        writer.Close();
                    }

                    myseting.error = false;
                    ViewBag.succes = true;
                    return View(myseting);
                }
                catch (Exception ex)
                {
                    //errors.
                    myseting.error = true;
                    ViewBag.succes = false;
                    return View(myseting);
                }
            }
            else if (myseting.button == "test")
            {
                try
                {
                    string path3 = "~/App_Data/seting.txt";
                    using (StreamReader JsonText = new StreamReader(path3, true))
                    {

                        string Jsonstring = JsonText.ReadToEnd();
                        var serverSettings = JsonConvert.DeserializeObject<seting>(Jsonstring, new JsonSerializerSettings());
                        bool succes = testconection(serverSettings);
                        ViewBag.testconection = "true";
                        return View(myseting);
                    }
                }
                catch (Exception ex)
                {
                    //errors.LogError(ex, getpath());
                    ViewBag.testconection = "false";
                    return View(myseting);
                }
            }
            return View(myseting);
        }
        [Authorize]
        public ActionResult list(int? page, string store1, string example)
        {
            
            var x = Request;

            List<commodity> vlist = new List<commodity>();

            var list = dataManagment.getall();
            List<filtercs> storlist = new List<filtercs>();
            foreach (var item in list)
            {
                if (storlist.Where(d => d.stor_id == item.id_store).Count() == 0)
                {
                    storlist.Add(new filtercs { name = item.name_store, stor_id = item.id_store });
                }
                else
                    if (item. != null || item.name_store != "")
                {
                    if (storlist.Where(d => d.stor_id == item.id_store).ToList()[0].name == null || storlist.Where(c => c.stor_id == item.id_store).ToList()[0].name == "")
                    {
                        storlist.Where(c => c.stor_id == item.id_store).ToList()[0].name = item.name_store;
                    }
                }

            }
            if (store1 != null || example != null)
            {
                string store = store1;
                string Example = example;
                ViewBag.store1 = store;
                ViewBag.example = Example;
                if (store != "all") list = list.Where(s => s.id_store.ToString() == store).ToList();
                if (Example == "on") list = list.Where(s => s.Amount > 0).ToList();
            }
            selectlist.list = null;
            selectlist.list = list;
            vlist = list.ToPagedList(page ?? 1, 9);
            ViewBag.store = storlist;
            return View(vlist);
        }
        public bool testconection(seting myseting)
        {
            if (myseting.FiscalYear == 95)
            {
                throw new Exeptioncs("FiscalYear", myseting.FiscalYear.ToString());
            }
            return false;

        }
        public ActionResult login(string ReturnUrl)
        {
            login log = new login();
            log.url = ReturnUrl;
            return View(log);
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult login(login log,string ReturnUrl)
        {
            string url = ReturnUrl;
            if (log.password != "password")
            {
                ViewBag.error = "true";
                return View(log);
            }
            FormsAuthentication.SetAuthCookie("admin", true);
            return Redirect(log.url);
        }
        public ActionResult logout()
        {
            if (User.Identity.IsAuthenticated != false)
            {
                FormsAuthentication.SignOut();
            }
            return Redirect("index");
        }
        public ActionResult dbacsses()
        {

            return View();
        }
        [Authorize]
        public ActionResult addCRM()
        {

            ViewBag.error = false;
            ViewBag.succes = false;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult addCRM(crm Crm)
        {
            bool f;
            if (ModelState.IsValid)
            {
               // f = crmManagment.add(Crm, getpath());
            }
            else
            {
              //  f = false;
            }

           // ViewBag.error = !f;
           // ViewBag.succes = f;
            return View();
        }
        [Authorize]
        public ActionResult serchCRM(int? page, string serch)
        {
            List<crm> list = new List<crm>();
            IPagedList Listc=null;
            if (query.get() == null)
            {
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
                    Lcrm = crmManagment.get();
                }
                else
                {
                    Lcrm = crmManagment.get(serch);
                }
                Listc = Lcrm.ToPagedList(page ?? 1, 6);

            }
            else
            {
                //list = query.get();
                ViewBag.serch = query.gets();
                ViewBag.succes = query.getb();
                ViewBag.error = !query.getb();
                query.set(null, null, false);
            }
            return View(Listc);
        }
        [Authorize]
        public ActionResult deletCrm(int? page, int id, string serch)
        {
            bool succes = crmManagment.delete(id, getpath());
            ViewBag.succes = succes;
            ViewBag.error = !succes;
            if (!string.IsNullOrEmpty(serch))
            {
                ViewBag.serch = serch;
            }
            List<crm> Lcrm = new List<crm>();
            if (string.IsNullOrEmpty(serch))
            {
                Lcrm = crmManagment.get();
            }
            else
            {
                Lcrm = crmManagment.get(serch);
            }
            IPagedList<crm> listc;
            listc = Lcrm.ToPagedList(page ?? 1, 9);

            query.set(listc, serch, succes);
            return Redirect("serchCRM");
        }

    }*/
}
