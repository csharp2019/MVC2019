using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zadaca.Models
{
    public class Artikl
    {
        public string Kategorija { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int Kolicina { get; set; }
    }
}