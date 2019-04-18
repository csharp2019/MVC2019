using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Poklon.Controllers
{
    public class IspitController : Controller
    {
        // GET: Ispit
        public ActionResult Prvi()
        {
            return View(DateTime.Now);
        }
    }
}