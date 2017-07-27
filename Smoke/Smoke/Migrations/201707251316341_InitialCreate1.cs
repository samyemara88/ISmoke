namespace Smoke.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        IdArt = c.Int(nullable: false, identity: true),
                        Prix = c.Single(nullable: false),
                        Categorie_IdCat = c.Int(),
                        Categorie_IdCat1 = c.Int(),
                        IdCat_IdCat = c.Int(),
                    })
                .PrimaryKey(t => t.IdArt)
                .ForeignKey("dbo.Categorie", t => t.Categorie_IdCat)
                .ForeignKey("dbo.Categorie", t => t.Categorie_IdCat1)
                .ForeignKey("dbo.Categorie", t => t.IdCat_IdCat)
                .Index(t => t.Categorie_IdCat)
                .Index(t => t.Categorie_IdCat1)
                .Index(t => t.IdCat_IdCat);
            
            CreateTable(
                "dbo.Categorie",
                c => new
                    {
                        IdCat = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.IdCat);
            
            CreateTable(
                "dbo.Commande",
                c => new
                    {
                        IdCmd = c.Int(nullable: false, identity: true),
                        Article_IdArt = c.Int(),
                        Categorie_IdCat = c.Int(),
                        Client_IdCli = c.Int(),
                        Client_IdCli1 = c.Int(),
                        IdArt_IdArt = c.Int(),
                        IdCat_IdCat = c.Int(),
                        IdCli_IdCli = c.Int(),
                        Article_IdArt1 = c.Int(),
                    })
                .PrimaryKey(t => t.IdCmd)
                .ForeignKey("dbo.Article", t => t.Article_IdArt)
                .ForeignKey("dbo.Categorie", t => t.Categorie_IdCat)
                .ForeignKey("dbo.Client", t => t.Client_IdCli)
                .ForeignKey("dbo.Client", t => t.Client_IdCli1)
                .ForeignKey("dbo.Article", t => t.IdArt_IdArt)
                .ForeignKey("dbo.Categorie", t => t.IdCat_IdCat)
                .ForeignKey("dbo.Client", t => t.IdCli_IdCli)
                .ForeignKey("dbo.Article", t => t.Article_IdArt1)
                .Index(t => t.Article_IdArt)
                .Index(t => t.Categorie_IdCat)
                .Index(t => t.Client_IdCli)
                .Index(t => t.Client_IdCli1)
                .Index(t => t.IdArt_IdArt)
                .Index(t => t.IdCat_IdCat)
                .Index(t => t.IdCli_IdCli)
                .Index(t => t.Article_IdArt1);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        IdCli = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Prenom = c.String(),
                        Adresse = c.String(),
                    })
                .PrimaryKey(t => t.IdCli);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Article", "IdCat_IdCat", "dbo.Categorie");
            DropForeignKey("dbo.Commande", "Article_IdArt1", "dbo.Article");
            DropForeignKey("dbo.Commande", "IdCli_IdCli", "dbo.Client");
            DropForeignKey("dbo.Commande", "IdCat_IdCat", "dbo.Categorie");
            DropForeignKey("dbo.Commande", "IdArt_IdArt", "dbo.Article");
            DropForeignKey("dbo.Commande", "Client_IdCli1", "dbo.Client");
            DropForeignKey("dbo.Commande", "Client_IdCli", "dbo.Client");
            DropForeignKey("dbo.Commande", "Categorie_IdCat", "dbo.Categorie");
            DropForeignKey("dbo.Commande", "Article_IdArt", "dbo.Article");
            DropForeignKey("dbo.Article", "Categorie_IdCat1", "dbo.Categorie");
            DropForeignKey("dbo.Article", "Categorie_IdCat", "dbo.Categorie");
            DropIndex("dbo.Commande", new[] { "Article_IdArt1" });
            DropIndex("dbo.Commande", new[] { "IdCli_IdCli" });
            DropIndex("dbo.Commande", new[] { "IdCat_IdCat" });
            DropIndex("dbo.Commande", new[] { "IdArt_IdArt" });
            DropIndex("dbo.Commande", new[] { "Client_IdCli1" });
            DropIndex("dbo.Commande", new[] { "Client_IdCli" });
            DropIndex("dbo.Commande", new[] { "Categorie_IdCat" });
            DropIndex("dbo.Commande", new[] { "Article_IdArt" });
            DropIndex("dbo.Article", new[] { "IdCat_IdCat" });
            DropIndex("dbo.Article", new[] { "Categorie_IdCat1" });
            DropIndex("dbo.Article", new[] { "Categorie_IdCat" });
            DropTable("dbo.Client");
            DropTable("dbo.Commande");
            DropTable("dbo.Categorie");
            DropTable("dbo.Article");
        }
    }
}
