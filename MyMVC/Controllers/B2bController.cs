using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Controllers
{
    public class B2bController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Customer()
        {
            return View();
        }

        public IActionResult CustomerView()
        {
            List<Customer> Customers = new List<Customer> ();
            Customers.Add(new Models.Customer { UserName = "Dimitris", Password = "xxx" });
            Customers.Add(new Models.Customer { UserName = "John", Password = "yyy" });
            return View(Customers);
        }

        public IActionResult CustomerCards()
        {
            List<Customer> Customers = new List<Customer> ();
            Customers.Add(new Models.Customer { UserName = "Dimitris", Password = "xxx" });
            Customers.Add(new Models.Customer { UserName = "John", Password = "yyy" });
            return View(Customers);
        }


    }
}
