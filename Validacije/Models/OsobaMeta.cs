using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Validacije.Models
{
    public class OsobaMeta:OsobaTempl
    {
        [HiddenInput(DisplayValue=false)]
        public int OsobaId { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string Email { get; set; }

        [Display(Name="Mjesto Stanovanja")]
        [UIHint("TemplMjesta")]
        public string MjestoStanovanja { get; set; }

        [UIHint("TemplSplo")]
        public string  Spol { get; set; }

        public bool Zaposlen { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }

        [UIHint("MultilineText")]
        public string Napomena { get; set; }

        public Adresa AdresaOsobe { get; set; }
    }
}