using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class NarudzbaArtiklaController : Controller
    {
        public ViewResult NaruciArtikal()
        {
            return View(new Artikal());
        }

        [HttpPost]
        public ViewResult NaruciArtikal(Artikal artikal)
        {
            if (artikal.Kolicina > 10)
            {
                ViewBag.Poruka = "Nema dovoljno " + artikal.Naziv + " na skladištu!";  
                return View(artikal);
            }
            else
            {
                ViewBag.Poruka = "Naručeno je " + 
                    artikal.Kolicina + 
                    " komada " + 
                    artikal.Naziv + 
                    " sa ukupnom cijenom " + 
                    artikal.Cijena * artikal.Kolicina;
                return View(artikal);
            }
        }
    }
}