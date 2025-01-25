namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class duzeltme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ImageUrl", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            AlterColumn("dbo.Products", "Ingredients", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Ingredients", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "ImageUrl", c => c.String(nullable: false, maxLength: 500));
        }
    }
}
