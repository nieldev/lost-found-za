namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blegh : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes");
            DropIndex("dbo.Categories", new[] { "Type_Id" });
            AlterColumn("dbo.Categories", "Type_Id", c => c.Long(nullable: false));
            CreateIndex("dbo.Categories", "Type_Id");
            AddForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes");
            DropIndex("dbo.Categories", new[] { "Type_Id" });
            AlterColumn("dbo.Categories", "Type_Id", c => c.Long());
            CreateIndex("dbo.Categories", "Type_Id");
            AddForeignKey("dbo.Categories", "Type_Id", "dbo.LostAndFoundTypes", "Id");
        }
    }
}
