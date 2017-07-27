namespace Smoke.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class touil1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Article", "UrlImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Article", "UrlImage");
        }
    }
}
