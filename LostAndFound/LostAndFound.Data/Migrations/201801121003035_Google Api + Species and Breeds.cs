namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GoogleApiSpeciesandBreeds : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Species", t => t.Species_Id)
                .Index(t => t.Species_Id);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        DisplayName = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pets", "Breed_Id", c => c.Long());
            AddColumn("dbo.Pets", "Species_Id", c => c.Long());
            CreateIndex("dbo.Pets", "Breed_Id");
            CreateIndex("dbo.Pets", "Species_Id");
            AddForeignKey("dbo.Pets", "Breed_Id", "dbo.Breeds", "Id");
            AddForeignKey("dbo.Pets", "Species_Id", "dbo.Species", "Id");
            DropColumn("dbo.Pets", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pets", "Type", c => c.Int(nullable: false));
            DropForeignKey("dbo.Pets", "Species_Id", "dbo.Species");
            DropForeignKey("dbo.Pets", "Breed_Id", "dbo.Breeds");
            DropForeignKey("dbo.Breeds", "Species_Id", "dbo.Species");
            DropIndex("dbo.Breeds", new[] { "Species_Id" });
            DropIndex("dbo.Pets", new[] { "Species_Id" });
            DropIndex("dbo.Pets", new[] { "Breed_Id" });
            DropColumn("dbo.Pets", "Species_Id");
            DropColumn("dbo.Pets", "Breed_Id");
            DropTable("dbo.Species");
            DropTable("dbo.Breeds");
        }
    }
}
