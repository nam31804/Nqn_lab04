using Nqn.Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Nqn.Lesson04.Controllers
{
    public class NqnCustomerController : Controller
    {
        // GET: NqnCustomer
        public ActionResult Index()
        {
            return View();
        }
        // action: NqncustomerDetail
        public ActionResult NqnCustomerDetail()
        {
            // tao doi tuong du lieu 
            var customer = new NqnCustomer()
            {
                CustomerId = 1,
                FirstName = "Nguyen Quang",
                LastName = "Nam",
                Address = "K22CNT2",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }
        // get: nqnlistcustomer
        public ActionResult NqnListCustomer()
        {
            var list = new List<NqnCustomer>();
            {
                new NqnCustomer()
                {
                    CustomerId = 1,
                    FirstName = "Nguyen Quang",
                    LastName = "Nam",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                };
                new NqnCustomer()
                {
                    CustomerId = 2,
                    FirstName = "Nguyen",
                    LastName = "Karl",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                };
                new NqnCustomer()
                {
                    CustomerId = 3,
                    FirstName = "Nguyen",
                    LastName = "Ca",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                };
                new NqnCustomer()
                {
                    CustomerId = 4,
                    FirstName = "Nguyen",
                    LastName = "Nam",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                };

            };
            //ViewBag.list = list; // dua du lieu ra view bang doi tuong viewbag

            return View(list);
        }

    }
}