using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class CustomerController : Controller
    {
        //private ApplicationDbContext _context;
        //// GET: Customer
        //public CustomerController()
        //{
        //    _context = new ApplicationDbContext();
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}

        public ViewResult Index()
        {
            var custmers = GetCustomers();
            return View(custmers);
            //var customers = _context.Customers.Include(i => i.MembershipType).ToList();
            //return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            
            if (customer == null)
                return HttpNotFound();
            
            return View(customer);
            //var customer = _context.Customers.Include(i => i.MembershipType).SingleOrDefault(i => i.Id == id);

            //if (customer == null)
            //{
            //    return HttpNotFound();
            //}
            //else
            //{
            //    return View(customer);
            //}
        }

        private IEnumerable<Customers> GetCustomers()
            {
                return new List<Customers>
                {
                    new Customers { Id = 1, CustomerName = "John Smith" },
                    new Customers { Id = 2, CustomerName = "Mary Williams" }
                };
            }
    }
}