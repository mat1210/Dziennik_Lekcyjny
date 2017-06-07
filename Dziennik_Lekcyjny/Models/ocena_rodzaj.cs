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
        public string wagaId { get; set; }
        public virtual ICollection<Waga> waga { get; set; }
    }
}