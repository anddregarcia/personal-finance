using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalFinance.Domain.Entities;
using PersonalFinance.WebUI.Models;

namespace PersonalFinance.WebUI.Controllers
{
    public class TransactionsController : Controller
    {
        private WebDbContext db = new WebDbContext();

        //
        // GET: /Transactions/

        public ActionResult Index()
        {
            var transactions = db.Transactions.Include(t => t.Account).Include(t => t.TransactionType).Include(t => t.Category);
            return View(transactions.ToList());
        }

        //
        // GET: /Transactions/Details/5

        public ActionResult Details(int id = 0)
        {
            Transactions transactions = db.Transactions.Find(id);
            if (transactions == null)
            {
                return HttpNotFound();
            }
            return View(transactions);
        }

        //
        // GET: /Transactions/Create

        public ActionResult Create()
        {
            ViewBag.AccountID = new SelectList(db.Accounts, "Id", "Name");
            ViewBag.TransactionTypeID = new SelectList(db.TransactionTypes, "Id", "Name");
            ViewBag.CategoryID = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        //
        // POST: /Transactions/Create

        [HttpPost]
        public ActionResult Create(Transactions transactions)
        {
            if (ModelState.IsValid)
            {
                db.Transactions.Add(transactions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AccountID = new SelectList(db.Accounts, "Id", "Name", transactions.AccountID);
            ViewBag.TransactionTypeID = new SelectList(db.TransactionTypes, "Id", "Name", transactions.TransactionTypeID);
            ViewBag.CategoryID = new SelectList(db.Categories, "Id", "Name", transactions.CategoryID);
            return View(transactions);
        }

        //
        // GET: /Transactions/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Transactions transactions = db.Transactions.Find(id);
            if (transactions == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccountID = new SelectList(db.Accounts, "Id", "Name", transactions.AccountID);
            ViewBag.TransactionTypeID = new SelectList(db.TransactionTypes, "Id", "Name", transactions.TransactionTypeID);
            ViewBag.CategoryID = new SelectList(db.Categories, "Id", "Name", transactions.CategoryID);
            return View(transactions);
        }

        //
        // POST: /Transactions/Edit/5

        [HttpPost]
        public ActionResult Edit(Transactions transactions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transactions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccountID = new SelectList(db.Accounts, "Id", "Name", transactions.AccountID);
            ViewBag.TransactionTypeID = new SelectList(db.TransactionTypes, "Id", "Name", transactions.TransactionTypeID);
            ViewBag.CategoryID = new SelectList(db.Categories, "Id", "Name", transactions.CategoryID);
            return View(transactions);
        }

        //
        // GET: /Transactions/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Transactions transactions = db.Transactions.Find(id);
            if (transactions == null)
            {
                return HttpNotFound();
            }
            return View(transactions);
        }

        //
        // POST: /Transactions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Transactions transactions = db.Transactions.Find(id);
            db.Transactions.Remove(transactions);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}