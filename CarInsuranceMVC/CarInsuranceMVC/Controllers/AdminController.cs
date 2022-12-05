using CarInsuranceMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var Insurees = db.Insurees;
                var InsureesList = new List<Insuree>();
                foreach (var insuree in Insurees)
                {
                    var insureeInfo = new Insuree();
                    insureeInfo.FirstName = insuree.FirstName;
                    insureeInfo.LastName = insuree.LastName;
                    insureeInfo.EmailAddress = insuree.EmailAddress;
                    insureeInfo.Quote = insuree.Quote;
                    InsureesList.Add(insureeInfo);

                    

                }
                return View(InsureesList);
            }
        }
    }
}