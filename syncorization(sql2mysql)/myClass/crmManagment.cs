using DataEditor.ErrorLog;
using DataEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data;

namespace DataEditor.myClass
{
    public interface IcrmManagment
    {
        public  List<crm> get();
        public  List<crm> get(string serch);
        public  bool add(crm Crm);
        public  bool delete(int id);
    }
    public class crmManagment:IcrmManagment
    {

        
        public  List<crm> get()
        {
            List<crm> Lcrm = new List<crm>();
            try
            {
                CRM2008Context dbcrm = new CRM2008Context();
                foreach (var item in dbcrm.CrmCustomers)
                {
                    if (item.IsDeleted != true)
                        Lcrm.Add(new crm
                        {
                            Id = item.Id,
                            Name = item.Name,
                            Number = item.Mobil,
                            NationalCode = item.CodeMelli,
                        });

                }
            }
            catch(Exception ex)
            {
                throw ;
            }

            return Lcrm;
        }
        public  List<crm> get(string serch)
        {
            List<crm> Lcrm = new List<crm>();
            Lcrm = get();
            Lcrm = Lcrm.Where(x => x.Name.Contains(serch) || x.NationalCode.ToString().Contains(serch) || x.Number.ToString().Contains(serch)).ToList();
            return Lcrm;
        }
        public  bool add(crm Crm)
        {
            try
            {
                CRM2008Context dbcrm = new CRM2008Context();
                var z = dbcrm.CrmCustomers.Where(x => x.Name == Crm.Name || x.Mobil == Crm.Number || x.CodeMelli == Crm.NationalCode);
                if (z.Count() != 0) return false;
                var newc = new CrmCustomer
                {
                    MosId = 2,
                    Name = Crm.Name,
                    CodeMelli = Crm.NationalCode,
                    ShsId = 0,
                    CodEshterak=Crm.NationalCode+"5555",
                    CartKind = "اشتراک",
                    Lottery = false

                };
                dbcrm.CrmCustomers.Add(newc);
                dbcrm.SaveChanges();
                return true;
            }

            catch (Exception error)
            {
                errors.LogError(error);

                return false;
            }
        }
        public  bool delete(int id)
        {

            try
            {
                CRM2008Context dbcrm = new CRM2008Context();
                var x = dbcrm.CrmCustomers.FirstOrDefault(x => x.Id == id);
                x.IsDeleted = true;
                dbcrm.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                errors.LogError(ex);
                return false;
            }

        }
    }
}