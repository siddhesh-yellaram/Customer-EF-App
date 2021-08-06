using CustomerEFApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerEFApp.Controllers
{
    public class CustomerController : Controller
    {
        private AurionProDBContext db = new AurionProDBContext();
        
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(db.Customers.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer cust)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Customers.Add(cust);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.Customers.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer cust)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(cust).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Customers.Where(x => x.Id == id).FirstOrDefault());
        }

        //POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer cust)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cust = db.Customers.Where(x => x.Id == id).FirstOrDefault();
                    db.Customers.Remove(cust);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            } 
        }
    }
}
