using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Adresar.WCFService.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("AdresarBaza"){
        }

        public virtual DbSet<Kontakt> Kontakti { get; set; }
    }
}