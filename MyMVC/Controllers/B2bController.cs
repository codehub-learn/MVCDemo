using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Controllers
{
    public class B2BController : Controller
    {


        private static readonly List<Customer> Customers = new()
        {
            new Models.Customer { UserName = "Dimitris", Password = "xxx", Id=1 },
            new Models.Customer { UserName = "John", Password = "yyy", Id=2 }
        };
        private static int counter = 2;

        private void create(Customer customer)
        {
            customer.Id = ++counter;
            Customers.Add(customer);
        }
        private Customer read(int index)
        {
            return Customers.FirstOrDefault(customer => customer.Id == index);
        }
        private void update(int index, Customer customer)
        {
            Customer dbCustomer = read(index);
            dbCustomer.UserName = customer.UserName;
            dbCustomer.Password = customer.Password;

        }
        private void delete(int index )
        {
            Customer dbCustomer = read(index);
            Customers.Remove(dbCustomer);
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateCustomer()
        {
            return View();
        }

        public IActionResult EditCustomer(Customer customer)
        {
            Customer dbCustomer = read(customer.Id);
            return View(dbCustomer);
        }

        public IActionResult DetailsCustomer(Customer customer)
        {
            return View(customer);
        }

        public IActionResult DeleteCustomer(Customer customer)
        {
            delete(customer.Id);
            return RedirectToAction("ViewCustomers");
        }


        public IActionResult ViewCustomers()
        {
            
            return View(Customers);
        }

        public IActionResult CustomerCards()
        {
           
            return View(Customers);
        }

        [HttpPost]
        public ActionResult Customer(Customer customer)
        {
            create(customer);
            return View("Index");
        }

        [HttpPost]
        public IActionResult DoEditCustomer(Customer customer)
        {
            update(customer.Id, customer);
            return RedirectToAction("ViewCustomers");
        }



    }
}
