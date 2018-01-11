namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Formatteddateadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "FormattedLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "FormattedLocation");
        }
    }
}
