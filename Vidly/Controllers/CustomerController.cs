using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Detail(int id)
        {
            var customers = GetCustomers();
            var returnCustomer = new Customer();

            foreach (var customer in customers) {
                if (customer.Id == id) {
                    returnCustomer = customer;
                }
            }

            return View(returnCustomer);

        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John" },
                new Customer { Id = 2, Name = "Jerry" }
            };

            return customers;
        }
    }
}