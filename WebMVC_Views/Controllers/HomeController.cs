using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC_Views.Models;

namespace WebMVC_Views.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Helper()
        {
            ViewBag.Countries = new List<string> { "Ukrine", "USA", "Brazil", "Poland" };
            ViewBag.Capitals = new string[] { "Kyiv", "Washington", "Brasília", "Warsaw" };

            return View();
        }

        public ActionResult StandartHelper()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StandartHelper(Student student)
        {
            return View("Details", student);
        }

        public ActionResult Details()
        {
            Student student = new Student
            {
                Id = 6,
                FirstName = "Vanya",
                LastName = "Zinov",
                Language = "C#"
            };
            return View(student);
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            return View("Details", student);
        }
    }
}