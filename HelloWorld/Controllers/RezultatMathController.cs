using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class RezultatMathController : Controller
    {
        // GET: RezultatMath
        public ActionResult Index()
        {

            string message = "Rezultat operacije 4 + 3 * 3 = ";
            return View((object)message);

        }
        public string Kvadriraj(int id)
        {
            return (id*id).ToString();
        }
    }
}