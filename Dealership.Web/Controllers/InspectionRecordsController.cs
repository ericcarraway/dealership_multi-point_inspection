using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dealership.Data;
using Dealership.Data.Models;

namespace Dealership.Web.Controllers
{
    public class InspectionRecordsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: InspectionRecords
        public async Task<ActionResult> Index()
        {
            return View(await db.InspectionRecords.ToListAsync());
        }

        // GET: InspectionRecords/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InspectionRecord inspectionRecord = await db.InspectionRecords.FindAsync(id);
            if (inspectionRecord == null)
            {
                return HttpNotFound();
            }
            return View(inspectionRecord);
        }

        // GET: InspectionRecords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InspectionRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Vin,DateIn,OwnerId,Horn,Lights_Signals,WindshieldWiper,WindshieldGlass,FuelCap,DomeLight,CabinFilter,ParkingBrake,DriverFloormat,AirFilter,BatteryCondition,BatteryHealth,CoolingSystems,Hoses,DriveBelts,Radiator_Condensor,WinshieldWasher,Coolant,PowerSteering,Brake,Clutch,Transmission,Differential,TransferCase,CvShaft,AxleHubBearing,SteeringLink,Suspension,FluidLeaks,Exhaust,FuelLines,Driveshaft,LfWear,LfTread,RfWear,RfTread,LrWear,LrTread,RrWear,RrTread,FrontPsi,BackPsi,LfBrakes,LrBrakes,RfBrakes,RrBrakes,BrakeLining,BrakeAssbly,Discs_Calipers")] InspectionRecord inspectionRecord)
        {
            if (ModelState.IsValid)
            {
                db.InspectionRecords.Add(inspectionRecord);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(inspectionRecord);
        }

        // GET: InspectionRecords/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InspectionRecord inspectionRecord = await db.InspectionRecords.FindAsync(id);
            if (inspectionRecord == null)
            {
                return HttpNotFound();
            }
            return View(inspectionRecord);
        }

        // POST: InspectionRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Vin,DateIn,OwnerId,Horn,Lights_Signals,WindshieldWiper,WindshieldGlass,FuelCap,DomeLight,CabinFilter,ParkingBrake,DriverFloormat,AirFilter,BatteryCondition,BatteryHealth,CoolingSystems,Hoses,DriveBelts,Radiator_Condensor,WinshieldWasher,Coolant,PowerSteering,Brake,Clutch,Transmission,Differential,TransferCase,CvShaft,AxleHubBearing,SteeringLink,Suspension,FluidLeaks,Exhaust,FuelLines,Driveshaft,LfWear,LfTread,RfWear,RfTread,LrWear,LrTread,RrWear,RrTread,FrontPsi,BackPsi,LfBrakes,LrBrakes,RfBrakes,RrBrakes,BrakeLining,BrakeAssbly,Discs_Calipers")] InspectionRecord inspectionRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inspectionRecord).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(inspectionRecord);
        }

        // GET: InspectionRecords/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InspectionRecord inspectionRecord = await db.InspectionRecords.FindAsync(id);
            if (inspectionRecord == null)
            {
                return HttpNotFound();
            }
            return View(inspectionRecord);
        }

        // POST: InspectionRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            InspectionRecord inspectionRecord = await db.InspectionRecords.FindAsync(id);
            db.InspectionRecords.Remove(inspectionRecord);
            await db.SaveChangesAsync();
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
