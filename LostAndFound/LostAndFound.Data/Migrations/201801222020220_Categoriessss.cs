namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categoriessss : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes");
            DropForeignKey("dbo.SubCategories", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "Type_Id" });
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Categories", "Id", c => c.Long(nullable: false));
            AlterColumn("dbo.Categories", "Type_Id", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Categories", "Id");
            CreateIndex("dbo.Categories", "Type_Id");
            AddForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SubCategories", "Category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes");
            DropIndex("dbo.Categories", new[] { "Type_Id" });
            DropPrimaryKey("dbo.Categories");
            AlterColumn("dbo.Categories", "Type_Id", c => c.Long());
            AlterColumn("dbo.Categories", "Id", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "Id");
            CreateIndex("dbo.Categories", "Type_Id");
            AddForeignKey("dbo.SubCategories", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes", "Id");
        }
    }
}
