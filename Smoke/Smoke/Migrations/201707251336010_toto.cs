namespace Smoke.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class toto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categorie", "UrlImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categorie", "UrlImage");
        }
    }
}
