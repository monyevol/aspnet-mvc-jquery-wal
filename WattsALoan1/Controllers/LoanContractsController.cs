using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WattsALoan1.Models;

namespace WattsALoan1.Controllers
{
    public class LoanContractsController : Controller
    {
        private LoansManagementModel db = new LoansManagementModel();

        // GET: LoanContracts
        public ActionResult Index()
        {
            return View(db.LoanContracts.ToList());
        }

        // GET: LoanContracts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanContract loanContract = db.LoanContracts.Find(id);

            ViewData["DateAllocated"] = DateTime.Parse(loanContract.DateAllocated.ToString()).ToLongDateString();
            ViewData["PaymentStartDate"] = DateTime.Parse(loanContract.PaymentStartDate.ToString()).ToLongDateString();

            if (loanContract == null)
            {
                return HttpNotFound();
            }
            return View(loanContract);
        }

        // GET: LoanContracts/Create
        public ActionResult Create()
        {
            Random rndNumber = new Random();
            List<SelectListItem> loanTypes = new List<SelectListItem>();

            ViewData["LoanNumber"] = rndNumber.Next(100001, 999999);

            loanTypes.Add(new SelectListItem() { Text = "Personal Loan", Value = "Personal Loan" });
            loanTypes.Add(new SelectListItem() { Text = "Car Financing", Value = "Car Financing" });
            loanTypes.Add(new SelectListItem() { Text = "Boat Financing", Value = "Boat Financing" });
            loanTypes.Add(new SelectListItem() { Text = "Furniture Purchase", Value = "Furniture Purchase" });
            loanTypes.Add(new SelectListItem() { Text = "Musical Instrument", Value = "Musical Instrument" });

            // Store the list in a View Bag so it can be access by a combo box
            ViewBag.LoanType = loanTypes;
            return View();
        }

        // POST: LoanContracts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoanContractId,LoanNumber,DateAllocated,EmployeeId,CustomerFirstName,CustomerLastName,LoanType,LoanAmount,InterestRate,Periods,MonthlyPayment,FutureValue,InterestAmount,PaymentStartDate")] LoanContract loanContract)
        {
            if (ModelState.IsValid)
            {
                db.LoanContracts.Add(loanContract);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loanContract);
        }

        // GET: LoanContracts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanContract loanContract = db.LoanContracts.Find(id);
            if (loanContract == null)
            {
                return HttpNotFound();
            }
            return View(loanContract);
        }

        // POST: LoanContracts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoanContractId,LoanNumber,DateAllocated,EmployeeId,CustomerFirstName,CustomerLastName,LoanType,LoanAmount,InterestRate,Periods,MonthlyPayment,FutureValue,InterestAmount,PaymentStartDate")] LoanContract loanContract)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loanContract).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loanContract);
        }

        // GET: LoanContracts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanContract loanContract = db.LoanContracts.Find(id);

            ViewData["DateAllocated"] = DateTime.Parse(loanContract.DateAllocated.ToString()).ToLongDateString();
            ViewData["PaymentStartDate"] = DateTime.Parse(loanContract.PaymentStartDate.ToString()).ToLongDateString();

            if (loanContract == null)
            {
                return HttpNotFound();
            }
            return View(loanContract);
        }

        // POST: LoanContracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoanContract loanContract = db.LoanContracts.Find(id);
            db.LoanContracts.Remove(loanContract);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
