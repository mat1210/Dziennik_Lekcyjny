using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.Models
{
    public class klasa
    {
        public int KlasaId { get; set; }
        public string Nazwa { get; set; }
        public virtual Uczen Uczen { get; set; }
        public virtual ICollection<Uczen> uczen { get; set; }
    }
}