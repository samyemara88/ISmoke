namespace Smoke.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class touil : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Article", "Nom", c => c.String());
            AddColumn("dbo.Article", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Article", "Description");
            DropColumn("dbo.Article", "Nom");
        }
    }
}
