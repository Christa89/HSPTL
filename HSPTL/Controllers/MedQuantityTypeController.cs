using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelData;
using System.Threading.Tasks;

namespace HSPTL.Controllers
{
    public class MedQuantityTypeController : Controller
    {
        private HospitalEntities db = new HospitalEntities();

        // GET: /MedQuantityType/
        public ActionResult Index()
        {
            return View(db.Med_quantity_type.ToList());
        }

        // GET: /MedQuantityType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
               return new  HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Med_quantity_type med_quantity_type = db.Med_quantity_type.Find(id);
            if (med_quantity_type == null)
            {
                return HttpNotFound();
            }
            return PartialView(med_quantity_type);
        }

        // GET: /MedQuantityType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MedQuantityType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Med_quan_typeId,Med_quan_type,Med_quantity")] Med_quantity_type med_quantity_type)
        {
            if (ModelState.IsValid)
            {
                db.Med_quantity_type.Add(med_quantity_type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(med_quantity_type);
        }

        // GET: /MedQuantityType/Edit/5
        public async Task<ActionResult>  Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Med_quantity_type med_quantity_type = await db.Med_quantity_type.FindAsync(id);
            if (med_quantity_type == null)
            {
                return HttpNotFound();
            }
            return  PartialView(med_quantity_type);
        }

        // POST: /MedQuantityType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult > Edit([Bind(Include = "Med_quan_typeId,Med_quan_type,Med_quantity")] Med_quantity_type med_quantity_type)
        {
            if (ModelState.IsValid)
            {
              db.Entry(med_quantity_type).State = EntityState.Modified;
              await db.SaveChangesAsync();
             return RedirectToAction("Index");
            }
            return View(med_quantity_type);
        }

        // GET: /MedQuantityType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Med_quantity_type med_quantity_type = db.Med_quantity_type.Find(id);
            if (med_quantity_type == null)
            {
                return HttpNotFound();
            }
            return View(med_quantity_type);
        }

        // POST: /MedQuantityType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Med_quantity_type med_quantity_type = db.Med_quantity_type.Find(id);
            db.Med_quantity_type.Remove(med_quantity_type);
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
