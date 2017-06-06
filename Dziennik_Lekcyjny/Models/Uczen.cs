using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.Models
{
    public class Uczen
    {
        public int UczenId { get; set; }
        public int KlasaId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public virtual klasa klasa { get; set; }
        public virtual przedmiot przedmiot { get; set; }
        public virtual ocena ocena { get; set; }
    }
}