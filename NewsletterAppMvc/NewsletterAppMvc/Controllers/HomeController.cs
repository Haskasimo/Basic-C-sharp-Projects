using NewsletterAppMvc.Models;
using NewsletterAppMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMvc.Controllers
{
    public class HomeController : Controller
    {               
  

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]//this will mark that that this method will have a post action
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)//this is model binding. it is mapping information coming in
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())//this is creating an object from the Ado.net framework which is a mapping library that can halp reduce code in order to map object t and from a database
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }
               
                    return View("Succsess");
            }     
                
        }
       

       
    }
}