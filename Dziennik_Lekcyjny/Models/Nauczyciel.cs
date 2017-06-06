using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.Models
{
    public class Nauczyciel
    {
        public int NauczycielId { get; set; }
        public int PrzedmiotId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

     //   public virtual klasa klasa { get; set; }
        public virtual Uczen uczen { get; set; }
        public virtual przedmiot przedmiot { get; set; }
        public virtual ocena ocena { get; set; }
        public virtual semestr semestr { get; set; }
        public virtual ocena_rodzaj ocena_rodzaj { get; set; }
    }
}