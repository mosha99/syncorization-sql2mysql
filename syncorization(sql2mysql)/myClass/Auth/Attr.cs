using DataEditor.myClass;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataEditor.Models;

namespace syncorization_sql2mysql_.myClass.Auth
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]

    public class AuthAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string ip = context.HttpContext.Connection.RemoteIpAddress?.ToString();
            TextEditor TEditor = new TextEditor("App_Data/seting.txt");
            string seting = TEditor.Reader();
            seting st = JsonConvert.DeserializeObject<seting>(seting);

            var Allow
                  = context
                  .ActionDescriptor.EndpointMetadata
                  .Where(x => x.ToString() == "Microsoft.AspNetCore.Authorization.AllowAnonymousAttribute")
                  .Count() != 0;

            string url = context.HttpContext.Request.Path;
            if (!Allow && context.HttpContext.Request.Cookies["woocport"] != (ip.GetHashCode() + st.pass.GetHashCode()).ToString())
            {
                context.Result = new Microsoft.AspNetCore.Mvc.RedirectResult($"~/home/login?ReturnUrl={url}");
            }
        }


    }
}
