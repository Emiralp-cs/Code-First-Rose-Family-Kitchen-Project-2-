namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdlwqdpowqjndfşlkqwndwqe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Chefs", "Title", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Chefs", "Description", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Chefs", "Description", c => c.String(maxLength: 10));
            AlterColumn("dbo.Chefs", "Title", c => c.String(maxLength: 3));
        }
    }
}
