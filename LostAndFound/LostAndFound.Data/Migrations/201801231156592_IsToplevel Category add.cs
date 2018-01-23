namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsToplevelCategoryadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "IsTopLevel", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "IsTopLevel");
        }
    }
}
