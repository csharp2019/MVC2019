using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validacije.Models;

namespace Validacije.Controllers
{
    public class MetaDataHtmlHelperiController : Controller
    {
        // GET: MetaDataHtmlHelperi
        public ActionResult MetaDataView()
        {
            return View(new OsobaMeta());
        }
        [HttpPost]
        public ActionResult MetaDataView(OsobaMeta osoba)
        {
            return View("~/Views/TemplHtmlHelperi/HtmlLabelDisplay.cshtml", osoba);
        }
        public ActionResult MetaDataView2()
        {
            return View(new OsobaMeta());
        }
        [HttpPost]
        public ActionResult MetaDataView2(OsobaMeta osoba)
        {
            return View("~/Views/TemplHtmlHelperi/HtmlLabelDisplay.cshtml", osoba);
        }
    }
}