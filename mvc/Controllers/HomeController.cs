using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public string test = "testowy napis";
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            if (hour < 17)
                ViewBag.Message = "goood moornig vieeetnaaam!";
            else
                ViewBag.Message = "fuck u too";
            
            return View();
        }

        public ViewResult RsvpFrom()
        {
            return View();
        }

    }
}
