//using DataEditor.Controllers;
using DataEditor.ErrorLog;
using DataEditor.Models;
//using DataEditor.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataEditor.myClass
{
    public static class crmManagment
    {
        
        //static CRM2008Entities dbcrm = new CRM2008Entities();
        public static List<crm> get()
        {
            List<crm> Lcrm = new List<crm>();
            try
            {
            //    foreach (var item in dbcrm.CRM_Customer)
            //    {

            //        Lcrm.Add(new crm
            //        {
            //            Id = item.id,
            //            Name = item.NAME,
            //            Number = item.MOBIL,
            //            NationalCode = item.CodeMelli,
            //        });

            //    }
            }
            catch
            {
                //foreach (var item in dbcrm.CRM_Customer)
                //{

                //    Lcrm.Add(new crm
                //    {
                //        Id = item.id,
                //        Name = item.NAME,
                //        Number = item.MOBIL,
                //        NationalCode = item.CodeMelli,
                //    });

                //}
            }
            
            return Lcrm;
        }
        public static List<crm> get(string serch)
        {
          List<crm> Lcrm = new List<crm>();
          Lcrm = get();
          Lcrm = Lcrm.Where(x => x.Name.Contains(serch) ||x.NationalCode.ToString().Contains(serch)|| x.Number.ToString().Contains(serch)).ToList();
          return Lcrm;
        }
        public static bool add(crm Crm,string path)
        {
            //int id = 0;
            try
            {
                //var db=dbcrm.CRM_Customer.OrderBy(x => x.id).ToList();
                //var ob = new CRM_Customer();
                //ob.id = db.Last().id + 1;
                //id = ob.id;
                //ob.NAME = Crm.Name;
                //ob.MOBIL = Crm.Number;
                //ob.CodeMelli = Crm.NationalCode;
                //ob.SHS_ID = 32906515;
                //ob.cod_Eshterak = ob.id.ToString();
                //ob.CartKind = "اشتراک";
                //ob.Mos_id = 0;
                //ob.Lottery = false;
                //    //SalMaly=dbcrm.SalMalies.FirstOrDefault(y=>y.SHS_ID==0)
                
                //dbcrm.CRM_Customer.Add(ob);
                //dbcrm.SaveChanges();
                return true;
            }

                catch (Exception error)
            {
                //dbcrm.CRM_Customer.Remove(dbcrm.CRM_Customer.FirstOrDefault(x=>x.id==id));
                errors.LogError(error, path);
                return false;
            }
        }
        public static bool delete(int id, string path)
        {
            try
            {
                //dbcrm.CRM_Customer.Remove(dbcrm.CRM_Customer.FirstOrDefault(x => x.id == id));
                //dbcrm.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                errors.LogError(ex, path);
                return false;
            }
            
        }
    }
}