using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zadaca.Models;

namespace zadaca.Controllers
{
    public class PrikazSaChildAkcijomController : Controller
    {
        // GET: PrikazSaChildAkcijom
        public ActionResult ObradiListu()
        {
            List<Artikl> lArtikli = new List<Artikl>()
            {
                new Artikl{Naziv = "čokolada", Cijena = 7.99m, Kategorija = "slatko"},
                new Artikl{Naziv = "čips", Cijena = 6.79m, Kategorija = "slano"},
                new Artikl{Naziv = "osječko pivo", Cijena = 5.49m, Kategorija = "pića"}
            };
            return View(lArtikli);
        }

        [ChildActionOnly]
        public string OdrediKategoriju(Artikl artikl)
        {
            return artikl.Kategorija;
        }
    }
}