using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WattsALoan1.Models;

namespace WattsALoan1.BusinessControllers
{
    public class LoanContractsController : ApiController
    {
        private LoansManagementModel db = new LoansManagementModel();

        // GET: api/LoanContracts
        public IQueryable<LoanContract> GetLoanContracts()
        {
            return db.LoanContracts;
        }

        // GET: api/LoanContracts/5
        [ResponseType(typeof(LoanContract))]
        public IHttpActionResult GetLoanContract(int id)
        {
            LoanContract loanContract = db.LoanContracts.Find(id);
            if (loanContract == null)
            {
                return NotFound();
            }

            return Ok(loanContract);
        }

        // PUT: api/LoanContracts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLoanContract(int id, LoanContract loanContract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != loanContract.LoanContractId)
            {
                return BadRequest();
            }

            db.Entry(loanContract).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoanContractExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/LoanContracts
        [ResponseType(typeof(LoanContract))]
        public IHttpActionResult PostLoanContract(LoanContract loanContract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LoanContracts.Add(loanContract);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = loanContract.LoanContractId }, loanContract);
        }

        // DELETE: api/LoanContracts/5
        [ResponseType(typeof(LoanContract))]
        public IHttpActionResult DeleteLoanContract(int id)
        {
            LoanContract loanContract = db.LoanContracts.Find(id);
            if (loanContract == null)
            {
                return NotFound();
            }

            db.LoanContracts.Remove(loanContract);
            db.SaveChanges();

            return Ok(loanContract);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LoanContractExists(int id)
        {
            return db.LoanContracts.Count(e => e.LoanContractId == id) > 0;
        }
    }
}