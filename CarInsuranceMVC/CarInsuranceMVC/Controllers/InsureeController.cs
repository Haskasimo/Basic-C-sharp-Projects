using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsuranceMVC.Models;

namespace CarInsuranceMVC.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        public decimal CalculateQuote(Insuree Insuree)//because we are only returning a value and not a view wer would not use Action Result for the method and only the data type we want returned.
        {
            decimal AgeFee = 50.00m;
            int Age = (Convert.ToInt32(DateTime.Now.Year)) - (Convert.ToInt32(Insuree.DateOfBirth.Year));
            if (Age <= 18 )
            {
                 AgeFee =+ 100.00m;
            }
            else if (Age >= 19 && Age <= 25)
            {
               AgeFee += 50.00m;
            }
            else
            {
                AgeFee += 25.00m;
            }

            decimal YearFee;
            if (Insuree.CarYear <= 2000)
            {
                YearFee = 25.00m;
            }
            else if (Insuree.CarYear >= 2001 && Insuree.CarYear <= 2015)
            {
                YearFee = 0.00m;
            }
            else
            {
                YearFee = 25.00m;
            }

            decimal MakeFee;
            if (Insuree.CarMake == "porsche")
            {
                MakeFee = 25.00m;
            }
            else if (Insuree.CarMake == "porsche" && Insuree.CarModel == "911 Carrera")
            {
                MakeFee = 50.00m;
            }
            else
            {
                MakeFee = 0.00m;
            }

            decimal TicketFee = Insuree.SpeedingTicket * 10m;

            decimal DUIFee;
            if (Insuree.DUI == true)
            {
                DUIFee = (AgeFee + YearFee + MakeFee + TicketFee) * .25m;
                     
            }
            else
            {
                DUIFee = 0m;
            }

            decimal CoverageFee;
            if(Insuree.CoverageType == true)
            {
                CoverageFee = (AgeFee + YearFee + MakeFee + TicketFee + DUIFee) * .50m;
            }
            else
            {
                CoverageFee = 0m;
            }

            Insuree.Quote = AgeFee + YearFee + MakeFee + TicketFee + DUIFee + CoverageFee;
            return (Insuree.Quote);//this returnes the final value to the method so this and only this will be the value passed to other parts of the program. 

            


        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
