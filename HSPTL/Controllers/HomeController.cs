using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSPTL.Controllers
{
    public class HomeController : Controller
    {

        [Authorize]
        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return View();
            }

            return RedirectToAction("Login","Account");
        }
        [Authorize]
        public ActionResult About()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}