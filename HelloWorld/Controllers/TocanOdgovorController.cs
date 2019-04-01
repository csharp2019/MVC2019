using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class TocanOdgovorController : Controller
    {
        // GET: TocanOdgovor
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult provjeri(string Odgovor)
        {
            string rezultat = "";
            switch (Odgovor)
            {
                case "crvena":
                case "crna":
                case "plava": rezultat = "Odgovor je netočan"; break;
                case "zelena": rezultat = "Odgovor je točan"; break;
            }

            return View("Index", (object)rezultat);
        }
    }
}