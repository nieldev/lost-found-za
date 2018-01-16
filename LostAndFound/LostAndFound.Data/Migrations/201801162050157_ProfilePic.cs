namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfilePic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ProfilePictureUri", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ProfilePictureUri");
        }
    }
}
