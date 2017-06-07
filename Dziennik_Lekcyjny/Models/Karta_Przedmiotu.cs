using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.Models
{
    public class Karta_Przedmiotu
    {
        public int Karta_PrzedmiotuId { get; set; }
        public int PrzedmiotId { get; set; }
        public int UczenId { get; set; }
        public int OcenaId { get; set; }
        public int NauczycielId { get; set; }
        public int Ocena_rodzajId { get; set; }
        public int SemestrId { get; set; }
        public int WagaId { get; set; }

        public virtual ICollection<Nauczyciel> Nauczyciel { get; set; }
        public virtual ICollection<przedmiot> przedmiot { get; set; }
        public virtual ICollection<ocena_rodzaj> ocena_rodzaj { get; set; }
        public virtual ICollection<ocena> ocena { get; set; }
        public virtual ICollection<semestr> semestr { get; set; }
        public virtual ICollection<Uczen> uczen { get; set; }

    }
}