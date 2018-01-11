namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedApplicationUserClaims : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NpoNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NpoNumber");
        }
    }
}
