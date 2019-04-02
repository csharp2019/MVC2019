using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class RazorSintaksaController : Controller
    {
        // GET: RazorSintaksa
        public ViewResult SwitchView()
        {
            return View();
        }
        public ViewResult ViewZaForPetlju()
        {
            string[] voce = new string[]
            {
                "Jabuka",
                "Kruska",
                "Banana",
                "Grožđe",
                "Šljiva"
            };
            return View(voce);
        }
    }
}