using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.Models
{
    public class ocena_rodzaj
    {
        public int Ocena_rodzajId { get; set; }
        public string Nazwa { get; set; }
        public string Semestr { get; set; }
       // public virtual semestr semestr { get; set; }
        public virtual przedmiot przedmiot { get; set; }
    }
}