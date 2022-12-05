using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page - The Tech Academy.";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Mara",
                LastName = "Haggar"
            };
            return View(dayTimeInstructor);
        }
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Bobby",
                    LastName = "Flay"
                },

                new Instructor
                {
                    Id = 2,
                    FirstName = "Gordon",
                    LastName = "Ramsey"
                },

                new Instructor
                {
                    Id = 3,
                    FirstName = "Janice",
                    LastName = "Wong"
                },
                new Instructor
                {
                    Id = 4,
                    FirstName = "Reynold",
                    LastName = "Poernomo"
                   }

            };
            return View(instructors); ;
        }
         
    }
}