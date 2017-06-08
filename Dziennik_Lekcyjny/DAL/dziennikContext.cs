using Dziennik_Lekcyjny.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Dziennik_Lekcyjny.DAL
{
    public class dziennikContext : DbContext
    {
        public dziennikContext() :base ("dziennikContext")
        {

        }

        static dziennikContext()
        {
            Database.SetInitializer<dziennikContext>(new dziennikInitializer());
        }
        public DbSet<Karta_Przedmiotu>Karta_Przedmiotu { get; set; }
        public DbSet<przedmiot> przedmioty { get; set; }
        public DbSet<Uczen> uczniowie { get; set; }
        public DbSet<Nauczyciel> Nauczyciel { get; set; }
        public DbSet<ocena> Ocena { get; set; }
        public DbSet<ocena_rodzaj> Ocena_rodzaj { get; set; }
        public DbSet<semestr> semestr { get; set; }
      
        public DbSet<Waga> waga { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}