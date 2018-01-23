namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveSubCat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SubCategories", "Category_Id", "dbo.Categories");
            DropIndex("dbo.SubCategories", new[] { "Category_Id" });
            DropTable("dbo.SubCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ExternalId = c.Int(nullable: false),
                        Name = c.String(),
                        DisplayName = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Category_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.SubCategories", "Category_Id");
            AddForeignKey("dbo.SubCategories", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
