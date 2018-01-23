namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PetCategoryLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Pets", "Category_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.Pets", "Category_Id");
            AddForeignKey("dbo.Pets", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Pets", new[] { "Category_Id" });
            DropColumn("dbo.Pets", "Category_Id");
            DropColumn("dbo.Pets", "CategoryId");
        }
    }
}
