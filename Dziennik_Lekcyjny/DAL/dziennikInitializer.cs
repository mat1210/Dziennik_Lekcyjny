using Dziennik_Lekcyjny.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Dziennik_Lekcyjny.Models;
using Dziennik_Lekcyjny.Migrations;
using System.Data.Entity.Migrations;

namespace Dziennik_Lekcyjny.DAL
{
    public class dziennikInitializer : MigrateDatabaseToLatestVersion<dziennikContext, Configuration>
    {
            public static void SeedDziennikData(dziennikContext context)
        {
            var Nauczyciel = new List<Nauczyciel>
            {
                new Nauczyciel() {NauczycielId=1, Imie="Adam", Nazwisko="Rak" }
            };
            Nauczyciel.ForEach(k => context.Nauczyciel.AddOrUpdate(k));
            context.SaveChanges();
        
        var uczniowie = new List<Uczen>
            {
                new Uczen() {UczenId=1, Imie="Adam", Nazwisko="Samok" },
                new Uczen() {UczenId=2, Imie="Mateusz", Nazwisko="Bog" }
            };
            uczniowie.ForEach(k => context.uczniowie.AddOrUpdate(k));
            context.SaveChanges();
       var przedmioty = new List<przedmiot>
            {
                new przedmiot() {PrzedmiotId=1, Nazwa="Biologia"},
                new przedmiot() {PrzedmiotId=2, Nazwa="Matematyka" }
            };
            przedmioty.ForEach(k => context.przedmioty.AddOrUpdate(k));
            context.SaveChanges();
        }
}
}