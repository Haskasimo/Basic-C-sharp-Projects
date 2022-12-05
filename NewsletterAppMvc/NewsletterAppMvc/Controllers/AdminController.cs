using NewsletterAppMvc.Models;
using NewsletterAppMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())//this new object will be used to access the database. Its goo to wrap code used to access the database ina a using statement so it automatically cloes when finished. 
            {
                
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();//only shows items in list where item in removed colomn is null
                var signupVms = new List<SignUpVM>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignUpVM();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }
                return View(signupVms);//passes the generated list to the view
            }
        }
        public ActionResult Unsubscribe(int Id)//once the button unsubscrib is hit, this will trigger
        {
            using(NewsletterEntities db = new NewsletterEntities())//since we want to ba able to close the connection to the database after we run the metod we wrap it in a using statment and create a new entity.
            {
                var signup = db.SignUps.Find(Id);//so this will search the record that matches the Id and assign it to signup. 
                signup.Removed = DateTime.Now;//the it will change the removed colomn to DateTime.Now
                db.SaveChanges();//it will save changes and close the conection.
            }
            return RedirectToAction("Index");//this will send it back to the index.
        }
    }

}