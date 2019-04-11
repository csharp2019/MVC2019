using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adresar.Models
{
    public class Kontakt
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string  Telefon { get; set; }
        public string Mobitel { get; set; }
        public string Email { get; set; }
        public string Napomena { get; set; }
        public bool Aktivan { get; set; }
    }
}