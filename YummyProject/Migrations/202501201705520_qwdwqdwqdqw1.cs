namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdwqdwqdqw1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Ingredients", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Ingredients", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
