using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
            //return @"<b>Just a test from Index</b>";
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            SecurityService sa = new SecurityService();
            if (sa.Authenticate(model))
            {
                //Login Passed
                return View("LoginPassed", model);
            }
            else
            {
                return View("LoginFailed");
            }
        }



    }
}