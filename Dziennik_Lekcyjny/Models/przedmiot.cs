using System.Collections.Generic;

namespace Dziennik_Lekcyjny.Models
{
    public class przedmiot
    {
        public int PrzedmiotId { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<ocena> ocena { get; set; }
        public virtual ICollection<ocena_rodzaj> ocena_rodzaj { get; set; }
        public virtual ICollection<Uczen> uczen { get; set; }
    }
}