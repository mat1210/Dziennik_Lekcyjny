using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.Models
{
    public class semestr
    {
        public int semestrId { get; set; }
        public int Numer_semestru { get; set; }
        public virtual przedmiot przedmiot { get; set; }
        public virtual ocena_rodzaj ocena_rodzaj { get; set; }
    }
}