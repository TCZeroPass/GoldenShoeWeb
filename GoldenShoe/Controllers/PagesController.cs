using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldenShoe.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        // GET: Pages
        public ActionResult FAQ()
        {
            ViewBag.Title = "FAQ Page";
            return View();
        }

        // GET: Pages
        public ActionResult Complaints()
        {
            ViewBag.Title = "Complaint Page";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact Page";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About Page";
            return View();
        }

        public ActionResult LoginPage()
        {
            ViewBag.Title = "Login Page";
            return View();
        }

        public ActionResult UserView()
        {
            ViewBag.Title = "User Page";
            return View();
        }
    }
}