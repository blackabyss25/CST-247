using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using Activity1Part3.Services.Utility;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        private static MyLogger1 logger = MyLogger1.GetInstance();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }
        [HttpPost]
        [CustomAction]
        public ActionResult Login(UserModel model)
        {
            logger.Info("Entering LoginController.DoLogin()");
            logger.Info("Parameters are:" + new JavaScriptSerializer().Serialize(model));
            if (!ModelState.IsValid)
            {
                logger.Error("Exception LoginController.DoLogin()", ModelState.IsValid);
                return View("Login");
            }
            SecurityService ss = new SecurityService();
            bool result = ss.Authenticate(model);
            if (result)
            {
                logger.Info("Exit LoginController.DoLogin() with login passing");
                Session["user"] = model;
                return View("LoginPassed", model);
            }
            else
            {
                Session.Clear();
                logger.Info("Exit LoginController.DoLogin() with login failing");
                return View("LoginFailed");
            }
        }
        [CustomAuthorization]
        public ActionResult onPrivateURL()
        {
            return Content("Private information here. Only a logged in user should be able to see it.");
        }


        public ActionResult getUsers()
        {
            var cache = MemoryCache.Default;
            List<UserModel> users = new List<UserModel>();
            users = (List<UserModel>)cache.Get("users");
            if(users == null)
            {
                users = new List<UserModel>();
                users.Add(new UserModel("1", "a"));
                users.Add(new UserModel("2", "b"));
                users.Add(new UserModel("3", "c"));
                users.Add(new UserModel("4", "d"));
                users.Add(new UserModel("5", "e"));
                var policy = new CacheItemPolicy().AbsoluteExpiration = DateTime.Now.AddMinutes(1);
                cache.Set("users", users, policy);
                logger.Info("Users were not in the cache");
            }
            else
            {
                logger.Info("Users were in the cache");
                //Do nothing...
            }

            return Content(new JavaScriptSerializer().Serialize(users));
        }

    }
}