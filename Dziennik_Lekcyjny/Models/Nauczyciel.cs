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

        public virtual ICollection<przedmiot> przedmiot { get; set; }


    }
}