namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "PrimaryColor", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "CoatType", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "CoatLength", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "Colorpattern", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "EyeType", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "EarType", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "TailType", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "SizeClassification", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "BodyMassClassification", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pets", "BodyMassClassification");
            DropColumn("dbo.Pets", "SizeClassification");
            DropColumn("dbo.Pets", "TailType");
            DropColumn("dbo.Pets", "EarType");
            DropColumn("dbo.Pets", "EyeType");
            DropColumn("dbo.Pets", "Colorpattern");
            DropColumn("dbo.Pets", "CoatLength");
            DropColumn("dbo.Pets", "CoatType");
            DropColumn("dbo.Pets", "Gender");
            DropColumn("dbo.Pets", "PrimaryColor");
        }
    }
}
