namespace Dziennik_Lekcyjny.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Karta_Przedmiotu",
                c => new
                    {
                        Karta_PrzedmiotuId = c.Int(nullable: false, identity: true),
                        PrzedmiotId = c.Int(nullable: false),
                        UczenId = c.Int(nullable: false),
                        OcenaId = c.Int(nullable: false),
                        NauczycielId = c.Int(nullable: false),
                        Ocena_rodzajId = c.Int(nullable: false),
                        SemestrId = c.Int(nullable: false),
                        WagaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Karta_PrzedmiotuId);
            
            CreateTable(
                "dbo.Nauczyciel",
                c => new
                    {
                        NauczycielId = c.Int(nullable: false, identity: true),
                        PrzedmiotId = c.Int(nullable: false),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Karta_Przedmiotu_Karta_PrzedmiotuId = c.Int(),
                    })
                .PrimaryKey(t => t.NauczycielId)
                .ForeignKey("dbo.Karta_Przedmiotu", t => t.Karta_Przedmiotu_Karta_PrzedmiotuId)
                .Index(t => t.Karta_Przedmiotu_Karta_PrzedmiotuId);
            
            CreateTable(
                "dbo.przedmiot",
                c => new
                    {
                        PrzedmiotId = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Nauczyciel_NauczycielId = c.Int(),
                        Karta_Przedmiotu_Karta_PrzedmiotuId = c.Int(),
                    })
                .PrimaryKey(t => t.PrzedmiotId)
                .ForeignKey("dbo.Nauczyciel", t => t.Nauczyciel_NauczycielId)
                .ForeignKey("dbo.Karta_Przedmiotu", t => t.Karta_Przedmiotu_Karta_PrzedmiotuId)
                .Index(t => t.Nauczyciel_NauczycielId)
                .Index(t => t.Karta_Przedmiotu_Karta_PrzedmiotuId);
            
            CreateTable(
                "dbo.ocena",
                c => new
                    {
                        OcenaId = c.Int(nullable: false, identity: true),
                        Ocena = c.Int(nullable: false),
                        Karta_Przedmiotu_Karta_PrzedmiotuId = c.Int(),
                    })
                .PrimaryKey(t => t.OcenaId)
                .ForeignKey("dbo.Karta_Przedmiotu", t => t.Karta_Przedmiotu_Karta_PrzedmiotuId)
                .Index(t => t.Karta_Przedmiotu_Karta_PrzedmiotuId);
            
            CreateTable(
                "dbo.ocena_rodzaj",
                c => new
                    {
                        Ocena_rodzajId = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        wagaId = c.String(),
                        Karta_Przedmiotu_Karta_PrzedmiotuId = c.Int(),
                    })
                .PrimaryKey(t => t.Ocena_rodzajId)
                .ForeignKey("dbo.Karta_Przedmiotu", t => t.Karta_Przedmiotu_Karta_PrzedmiotuId)
                .Index(t => t.Karta_Przedmiotu_Karta_PrzedmiotuId);
            
            CreateTable(
                "dbo.Waga",
                c => new
                    {
                        WagaId = c.Int(nullable: false, identity: true),
                        waga = c.String(),
                        ocena_rodzaj_Ocena_rodzajId = c.Int(),
                    })
                .PrimaryKey(t => t.WagaId)
                .ForeignKey("dbo.ocena_rodzaj", t => t.ocena_rodzaj_Ocena_rodzajId)
                .Index(t => t.ocena_rodzaj_Ocena_rodzajId);
            
            CreateTable(
                "dbo.semestr",
                c => new
                    {
                        semestrId = c.Int(nullable: false, identity: true),
                        Numer_semestru = c.Int(nullable: false),
                        Karta_Przedmiotu_Karta_PrzedmiotuId = c.Int(),
                    })
                .PrimaryKey(t => t.semestrId)
                .ForeignKey("dbo.Karta_Przedmiotu", t => t.Karta_Przedmiotu_Karta_PrzedmiotuId)
                .Index(t => t.Karta_Przedmiotu_Karta_PrzedmiotuId);
            
            CreateTable(
                "dbo.Uczen",
                c => new
                    {
                        UczenId = c.Int(nullable: false, identity: true),
                        KlasaId = c.Int(nullable: false),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        klasa_KlasaId = c.Int(),
                        Karta_Przedmiotu_Karta_PrzedmiotuId = c.Int(),
                    })
                .PrimaryKey(t => t.UczenId)
                .ForeignKey("dbo.klasa", t => t.klasa_KlasaId)
                .ForeignKey("dbo.Karta_Przedmiotu", t => t.Karta_Przedmiotu_Karta_PrzedmiotuId)
                .Index(t => t.klasa_KlasaId)
                .Index(t => t.Karta_Przedmiotu_Karta_PrzedmiotuId);
            
            CreateTable(
                "dbo.klasa",
                c => new
                    {
                        KlasaId = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                        Uczen_UczenId = c.Int(),
                        Uczen_UczenId1 = c.Int(),
                    })
                .PrimaryKey(t => t.KlasaId)
                .ForeignKey("dbo.Uczen", t => t.Uczen_UczenId)
                .ForeignKey("dbo.Uczen", t => t.Uczen_UczenId1)
                .Index(t => t.Uczen_UczenId)
                .Index(t => t.Uczen_UczenId1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uczen", "Karta_Przedmiotu_Karta_PrzedmiotuId", "dbo.Karta_Przedmiotu");
            DropForeignKey("dbo.klasa", "Uczen_UczenId1", "dbo.Uczen");
            DropForeignKey("dbo.klasa", "Uczen_UczenId", "dbo.Uczen");
            DropForeignKey("dbo.Uczen", "klasa_KlasaId", "dbo.klasa");
            DropForeignKey("dbo.semestr", "Karta_Przedmiotu_Karta_PrzedmiotuId", "dbo.Karta_Przedmiotu");
            DropForeignKey("dbo.przedmiot", "Karta_Przedmiotu_Karta_PrzedmiotuId", "dbo.Karta_Przedmiotu");
            DropForeignKey("dbo.ocena_rodzaj", "Karta_Przedmiotu_Karta_PrzedmiotuId", "dbo.Karta_Przedmiotu");
            DropForeignKey("dbo.Waga", "ocena_rodzaj_Ocena_rodzajId", "dbo.ocena_rodzaj");
            DropForeignKey("dbo.ocena", "Karta_Przedmiotu_Karta_PrzedmiotuId", "dbo.Karta_Przedmiotu");
            DropForeignKey("dbo.Nauczyciel", "Karta_Przedmiotu_Karta_PrzedmiotuId", "dbo.Karta_Przedmiotu");
            DropForeignKey("dbo.przedmiot", "Nauczyciel_NauczycielId", "dbo.Nauczyciel");
            DropIndex("dbo.klasa", new[] { "Uczen_UczenId1" });
            DropIndex("dbo.klasa", new[] { "Uczen_UczenId" });
            DropIndex("dbo.Uczen", new[] { "Karta_Przedmiotu_Karta_PrzedmiotuId" });
            DropIndex("dbo.Uczen", new[] { "klasa_KlasaId" });
            DropIndex("dbo.semestr", new[] { "Karta_Przedmiotu_Karta_PrzedmiotuId" });
            DropIndex("dbo.Waga", new[] { "ocena_rodzaj_Ocena_rodzajId" });
            DropIndex("dbo.ocena_rodzaj", new[] { "Karta_Przedmiotu_Karta_PrzedmiotuId" });
            DropIndex("dbo.ocena", new[] { "Karta_Przedmiotu_Karta_PrzedmiotuId" });
            DropIndex("dbo.przedmiot", new[] { "Karta_Przedmiotu_Karta_PrzedmiotuId" });
            DropIndex("dbo.przedmiot", new[] { "Nauczyciel_NauczycielId" });
            DropIndex("dbo.Nauczyciel", new[] { "Karta_Przedmiotu_Karta_PrzedmiotuId" });
            DropTable("dbo.klasa");
            DropTable("dbo.Uczen");
            DropTable("dbo.semestr");
            DropTable("dbo.Waga");
            DropTable("dbo.ocena_rodzaj");
            DropTable("dbo.ocena");
            DropTable("dbo.przedmiot");
            DropTable("dbo.Nauczyciel");
            DropTable("dbo.Karta_Przedmiotu");
        }
    }
}
