using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public string test = "testowy napis";
        public ActionResult Index() // poczatkowa strona
        {
            int hour = DateTime.Now.Hour;

            if (hour < 17)
                ViewBag.Message = "goood moorning vieeetnaaam!";
            else
                ViewBag.Message = "other greeting";
            
            return View();
        }

        [HttpGet] //get
        public ViewResult RsvpForm() // formularz który jest dostepny po klikneciu liku rsvpForm w na glownej stronie - polaczenie przez nazwe
        {
            return View(); // odpala widok RspForm
        }

        
        [HttpPost] //post == set
        public ViewResult RsvpForm(GuestResponse guestResponse) //zapisane dane sa przechwytywane przez ta metode
        {
            return View("Thanks", guestResponse); // zbiera dane wpisane w formularz i wprowadza do obiektu guestResponse
                                                  // THANKS to nazwa widoku! zajebiste!
        }
    }
}
