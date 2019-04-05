using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validacije.Models;


namespace Validacije.Controllers
{
    public class TemplHtmlHelperiController : Controller
    {
        // GET: TemplHtmlHelperi
        public ActionResult HtmlEditorView()
        {
            return View(new OsobaTempl());
        }
        [HttpPost]
        public ActionResult HtmlEditorView(OsobaTempl osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}