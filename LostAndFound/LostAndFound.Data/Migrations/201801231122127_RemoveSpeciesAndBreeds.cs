namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSpeciesAndBreeds : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Breeds", "Species_Id", "dbo.Species");
            DropForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes");
            DropForeignKey("dbo.Pets", "Breed_Id", "dbo.Breeds");
            DropForeignKey("dbo.Pets", "Species_Id", "dbo.Species");
            DropIndex("dbo.Breeds", new[] { "Species_Id" });
            DropIndex("dbo.Categories", new[] { "Type_Id" });
            DropIndex("dbo.Pets", new[] { "Breed_Id" });
            DropIndex("dbo.Pets", new[] { "Species_Id" });
            DropColumn("dbo.Categories", "Type_Id");
            DropColumn("dbo.Pets", "Breed_Id");
            DropColumn("dbo.Pets", "Species_Id");
            DropTable("dbo.Breeds");
            DropTable("dbo.Species");
            DropTable("dbo.LostAndFoundTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LostAndFoundTypes",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        ExternalId = c.Int(nullable: false),
                        Name = c.String(),
                        DisplayName = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Name = c.String(),
                        DisplayName = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Breeds",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        DisplayName = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Species_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pets", "Species_Id", c => c.Long());
            AddColumn("dbo.Pets", "Breed_Id", c => c.Long());
            AddColumn("dbo.Categories", "Type_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.Pets", "Species_Id");
            CreateIndex("dbo.Pets", "Breed_Id");
            CreateIndex("dbo.Categories", "Type_Id");
            CreateIndex("dbo.Breeds", "Species_Id");
            AddForeignKey("dbo.Pets", "Species_Id", "dbo.Species", "Id");
            AddForeignKey("dbo.Pets", "Breed_Id", "dbo.Breeds", "Id");
            AddForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Breeds", "Species_Id", "dbo.Species", "Id");
        }
    }
}
