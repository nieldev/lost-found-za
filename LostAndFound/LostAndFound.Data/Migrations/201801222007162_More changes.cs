namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Morechanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ExternalId", c => c.Int(nullable: false));
            AddColumn("dbo.SubCategories", "ExternalId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubCategories", "ExternalId");
            DropColumn("dbo.Categories", "ExternalId");
        }
    }
}
