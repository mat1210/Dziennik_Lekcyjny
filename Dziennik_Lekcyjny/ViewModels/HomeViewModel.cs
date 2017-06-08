using Dziennik_Lekcyjny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable <Nauczyciel>Nauczyciel { get; set; }
        public IEnumerable<Uczen> Uczniowie{ get; set; }

    }
}