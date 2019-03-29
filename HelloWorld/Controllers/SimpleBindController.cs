using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class SimpleBindController : Controller
    {
        // GET: /SimpleBind/SimpleBindMetoda
        public ViewResult SimpleBindMetoda()
        {
            return View("SimpleBind");
        }
        // POST: SimpleBind
        [HttpPost]
        public ViewResult SimpleBindMetoda(string ime)
        {
            string pozdrav = "Poz, moje ime je " + ime;
            return View("SimpleBind",(object)pozdrav);
        }

    }
}