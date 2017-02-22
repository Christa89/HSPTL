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
using ModelData;

namespace HSPTL.Controllers
{
    public class MedQuantityTypeApiController : ApiController
    {
        private HospitalEntities db = new HospitalEntities();

      

        // GET api/MedQuantityTypeApi
        public IQueryable<Med_quantity_type> GetMed_quantity_type()
        {
            return db.Med_quantity_type;
        }

        // GET api/MedQuantityTypeApi/5
        [ResponseType(typeof(Med_quantity_type))]
        public async Task<IHttpActionResult> GetMed_quantity_type(int id)
        {
            Med_quantity_type med_quantity_type = await db.Med_quantity_type.FindAsync(id);
            if (med_quantity_type == null)
            {
                return NotFound();
            }

            return Ok(med_quantity_type);
        }

        // PUT api/MedQuantityTypeApi/5
        public async Task<IHttpActionResult> PutMed_quantity_type(int id, Med_quantity_type med_quantity_type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != med_quantity_type.Med_quan_typeId)
            {
                return BadRequest();
            }

            db.Entry(med_quantity_type).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Med_quantity_typeExists(id))
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

        // POST api/MedQuantityTypeApi
        [ResponseType(typeof(Med_quantity_type))]
        public async Task<IHttpActionResult> PostMed_quantity_type(Med_quantity_type med_quantity_type)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Med_quantity_type.Add(med_quantity_type);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = med_quantity_type.Med_quan_typeId }, med_quantity_type);
        }

        // DELETE api/MedQuantityTypeApi/5
        [ResponseType(typeof(Med_quantity_type))]
        public async Task<IHttpActionResult> DeleteMed_quantity_type(int id)
        {
            Med_quantity_type med_quantity_type = await db.Med_quantity_type.FindAsync(id);
            if (med_quantity_type == null)
            {
                return NotFound();
            }

            db.Med_quantity_type.Remove(med_quantity_type);
            await db.SaveChangesAsync();

            return Ok(med_quantity_type);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Med_quantity_typeExists(int id)
        {
            return db.Med_quantity_type.Count(e => e.Med_quan_typeId == id) > 0;
        }
    }
}