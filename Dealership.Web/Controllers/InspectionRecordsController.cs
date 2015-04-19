using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Dealership.Data;
using Dealership.Data.Models;

namespace Dealership.Web.Controllers
{
    public class InspectionRecordsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/InspectionRecords
        public IQueryable<InspectionRecord> GetInspectionRecords()
        {
            return db.InspectionRecords;
        }

        // GET: api/InspectionRecords/5
        [ResponseType(typeof(InspectionRecord))]
        public async Task<IHttpActionResult> GetInspectionRecord(int id)
        {
            InspectionRecord inspectionRecord = await db.InspectionRecords.FindAsync(id);
            if (inspectionRecord == null)
            {
                return NotFound();
            }

            return Ok(inspectionRecord);
        }

        // PUT: api/InspectionRecords/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutInspectionRecord(int id, InspectionRecord inspectionRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != inspectionRecord.Id)
            {
                return BadRequest();
            }

            db.Entry(inspectionRecord).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectionRecordExists(id))
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

        // POST: api/InspectionRecords
        [ResponseType(typeof(InspectionRecord))]
        public async Task<IHttpActionResult> PostInspectionRecord(InspectionRecord inspectionRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.InspectionRecords.Add(inspectionRecord);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = inspectionRecord.Id }, inspectionRecord);
        }

        // DELETE: api/InspectionRecords/5
        [ResponseType(typeof(InspectionRecord))]
        public async Task<IHttpActionResult> DeleteInspectionRecord(int id)
        {
            InspectionRecord inspectionRecord = await db.InspectionRecords.FindAsync(id);
            if (inspectionRecord == null)
            {
                return NotFound();
            }

            db.InspectionRecords.Remove(inspectionRecord);
            await db.SaveChangesAsync();

            return Ok(inspectionRecord);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InspectionRecordExists(int id)
        {
            return db.InspectionRecords.Count(e => e.Id == id) > 0;
        }
    }
}