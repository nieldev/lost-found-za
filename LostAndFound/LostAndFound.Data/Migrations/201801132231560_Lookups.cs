namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lookups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        IsoAlpha2Code = c.String(),
                        IsoAlpha3Code = c.String(),
                        IsoNumericCode = c.String(),
                        DialingCode = c.String(),
                        InternationalDialingPrefix = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Locations", "Country_Id", c => c.Long());
            CreateIndex("dbo.Locations", "Country_Id");
            AddForeignKey("dbo.Locations", "Country_Id", "dbo.Countries", "Id");
            DropColumn("dbo.Locations", "Country_Name");
            DropColumn("dbo.Locations", "Country_IsoAlpha2Code");
            DropColumn("dbo.Locations", "Country_IsoAlpha3Code");
            DropColumn("dbo.Locations", "Country_IsoNumericCode");
            DropColumn("dbo.Locations", "Country_DialingCode");
            DropColumn("dbo.Locations", "Country_InternationalDialingPrefix");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "Country_InternationalDialingPrefix", c => c.String());
            AddColumn("dbo.Locations", "Country_DialingCode", c => c.String());
            AddColumn("dbo.Locations", "Country_IsoNumericCode", c => c.String());
            AddColumn("dbo.Locations", "Country_IsoAlpha3Code", c => c.String());
            AddColumn("dbo.Locations", "Country_IsoAlpha2Code", c => c.String());
            AddColumn("dbo.Locations", "Country_Name", c => c.String());
            DropForeignKey("dbo.Locations", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Locations", new[] { "Country_Id" });
            DropColumn("dbo.Locations", "Country_Id");
            DropTable("dbo.Countries");
        }
    }
}
