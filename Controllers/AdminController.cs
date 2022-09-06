using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAD_Project.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NowShowing()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View();
        }

        public ActionResult Bookings()
        {
            return View();
        }

        public ActionResult ManageMovies()
        {
            return View();
        }

        public ActionResult AddMovie()
        {
            return View();
        }
    }
}