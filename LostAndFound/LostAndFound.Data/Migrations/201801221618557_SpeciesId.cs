namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpeciesId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Breeds", "Species_Id", "dbo.Species");
            DropForeignKey("dbo.Pets", "Species_Id", "dbo.Species");
            DropPrimaryKey("dbo.Species");
            AlterColumn("dbo.Species", "Id", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Species", "Id");
            AddForeignKey("dbo.Breeds", "Species_Id", "dbo.Species", "Id");
            AddForeignKey("dbo.Pets", "Species_Id", "dbo.Species", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "Species_Id", "dbo.Species");
            DropForeignKey("dbo.Breeds", "Species_Id", "dbo.Species");
            DropPrimaryKey("dbo.Species");
            AlterColumn("dbo.Species", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Species", "Id");
            AddForeignKey("dbo.Pets", "Species_Id", "dbo.Species", "Id");
            AddForeignKey("dbo.Breeds", "Species_Id", "dbo.Species", "Id");
        }
    }
}
