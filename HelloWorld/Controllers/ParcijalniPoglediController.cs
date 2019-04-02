using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class ParcijalniPoglediController : Controller
    {
        // GET: ParcijalniPogledi
        public ActionResult PrikaziKosaricu()
        {
            List<Artikal> ListaArtikala = new List<Artikal>()
            {
 new Artikal(){Cijena=9.99m, Kategorija="plava", Kolicina=5, Naziv="Keks"},
  new Artikal(){Cijena=8.99m, Kategorija="zelena", Kolicina=7, Naziv="Kifla"},
   new Artikal(){Cijena=5.99m, Kategorija="zuta", Kolicina=20, Naziv="Kroki"}
            };
            return View(ListaArtikala);
        }
    }
}