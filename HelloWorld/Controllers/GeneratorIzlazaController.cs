using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class GeneratorIzlazaController : Controller
    {
        // GeneratorIzlaza/PopisKosarice
        public ActionResult PopisKosarice()
        {
            return View();
        }

        // GeneratorIzlaza/ListaArtikala
        public ActionResult ListaArtikala()
        {
            string[] lista = new string[] { "Skije", "Pancerice", "Sunčane naočale", "Šal", "Kapa" };
            ViewBag.Lista = lista;
            return View();
        }

        // GeneratorIzlaza/RedirectNaMetodu/Kosarica
        public ActionResult RedirectNaMetodu(string id)
        {
            if (id == "Kosarica")
            {
                return RedirectToAction("PopisKosarice");
            }
            else
            {
                return RedirectToAction("ListaArtikala");
            }
        }
    }
}