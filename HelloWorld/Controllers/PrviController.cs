using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi/MetodaSParametrima/1349
        public ActionResult MetodaSParametrima(int id=9431)
        {
            // return View();
            return Content(id.ToString());
        }

        // GET: Drugi/MetodaSParametrima/54321
        public ViewResult DrugaMetodaSParametrima(int? id)
        {
            if (id == null)
            {
                id = 777;
            }
            return View((object)id);
            //return Content(id.ToString());
        }
    }
}