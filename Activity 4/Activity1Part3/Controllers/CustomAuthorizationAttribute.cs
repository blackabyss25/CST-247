using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    internal class CustomAuthorizationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            SecurityService ss = new SecurityService();

            UserModel user = (UserModel)filterContext.HttpContext.Session["user"];
            bool success = false;
            if (user != null)
            {
                success = ss.Authenticate(user);
            }

            
            if (success)
            {
                // Do nothing... successful login
            }
            else
            {
                filterContext.Result = new RedirectResult("/login");
            }
        }
    }
}