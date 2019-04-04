using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zadaca.Models;

namespace zadaca.Controllers
{
    public class ListaArtikalaController : Controller
    {
        // GET: ListaArtikala/UnesiArtikl
        public ActionResult UnesiArtikl()
        {
            ViewBag.Kategorije = new string[] { "slatko", "slano", "pića" };
            return View(new Artikl());
        }

        [HttpPost]
        public ActionResult DodajArtikl(Artikl artikl)
        {
            if (Session["Artikli"] != null)
            {
                List<Artikl> artikli = (List<Artikl>)Session["Artikli"];
                artikli.Add(artikl);
                Session["Artikli"] = artikli;
            }
            else
            {
                List<Artikl> artikli = new List<Artikl>();
                artikli.Add(artikl);
                Session["Artikli"] = artikli;
            }
            return View(Session["Artikli"]);
        }
    }
}