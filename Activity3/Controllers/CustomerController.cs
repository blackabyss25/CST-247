using Activity3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers;
        // GET: Customer

        public CustomerController()
        {
            CustomerModel c1 = new CustomerModel(0, "Kurt", 27);
            CustomerModel c2 = new CustomerModel(1, "Isaac", 24);
            CustomerModel c3 = new CustomerModel(2, "An", 26);
            CustomerModel c4 = new CustomerModel(3, "Alex", 26);
            CustomerModel c5 = new CustomerModel(4, "Katie", 29);
            CustomerModel c6 = new CustomerModel(5, "Kathy", 63);



            customers = new List<CustomerModel>();

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);
            customers.Add(c6);
        }

        public ActionResult Index()
        {
            Tuple<List<CustomerModel>, CustomerModel> t = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[0]);
            return View("Customer", t);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<CustomerModel>, CustomerModel> t = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[Int32.Parse(CustomerNumber)]);
            return PartialView("_CustomerDetails", t.Item2);
        }

        [HttpPost]
        public string GetMoreInfo(string CustomerNumber)
        {
            return "GetMoreInfo Success!";
        }


    }
}