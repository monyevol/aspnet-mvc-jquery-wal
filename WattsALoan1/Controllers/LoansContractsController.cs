using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WattsALoan10.Controllers
{
    public class LoansContractsController : Controller
    {
        // GET: LoansContracts
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoansContracts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoansContracts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoansContracts/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoansContracts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoansContracts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoansContracts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoansContracts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
