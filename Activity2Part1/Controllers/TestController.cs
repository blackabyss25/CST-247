using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        List<UserModel> users;
        // GET: Test
        public ActionResult Index()
        {
            users = new List<UserModel>();
            users.Add(new UserModel("Kurt","knewcomb@gcu.com","1(800)000-0000"));
            users.Add(new UserModel("Isaac", "issac@gcu.com", "1(911)111-1111"));
            users.Add(new UserModel("Michael", "michael@gcu.com", "1(122)222-2222"));
            return View("Test", users);
        }
    }
}