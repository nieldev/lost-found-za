namespace LostAndFound.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixCategoryId : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pets", new[] { "Category_Id" });
            DropColumn("dbo.Pets", "CategoryId");
            RenameColumn(table: "dbo.Pets", name: "Category_Id", newName: "CategoryId");
            AlterColumn("dbo.Pets", "CategoryId", c => c.Long(nullable: false));
            CreateIndex("dbo.Pets", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pets", new[] { "CategoryId" });
            AlterColumn("dbo.Pets", "CategoryId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Pets", name: "CategoryId", newName: "Category_Id");
            AddColumn("dbo.Pets", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pets", "Category_Id");
        }
    }
}
