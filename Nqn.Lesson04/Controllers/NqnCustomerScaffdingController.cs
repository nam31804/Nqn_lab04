using Nqn.Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Nqn.Lesson04.Controllers
{
    public class NqnCustomerScaffdingController : Controller
    {
        //mocdata
        private List<NqnCustomer> listCustomer = new List<NqnCustomer>()
            {
                new NqnCustomer()
        {
            CustomerId = 1,
                    FirstName = "Nguyen Quang",
                    LastName = "Nam",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                },
        new NqnCustomer()
        {
            CustomerId = 2,
                    FirstName = "Nguyen",
                    LastName = "Karl",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                },
        new NqnCustomer()
        {
            CustomerId = 3,
                    FirstName = "Nguyen",
                    LastName = "Ca",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                },
        new NqnCustomer()
        {
            CustomerId = 4,
                    FirstName = "Nguyen",
                    LastName = "Nam",
                    Address = "K22CNT2",
                    YearOfBirth = 2004
                },
    };
        // GET: NqnCustomerScaffding
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        public ActionResult NqnCreate()
        {
            var model = new NqnCustomer();
            return View(model);
        }
        public ActionResult NqnCreate(NqnCustomer model)
        {
            listCustomer.Add(model);
            // return View(model);//
            return RedirectToAction("Index");  
        }
        public ActionResult NqnEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}