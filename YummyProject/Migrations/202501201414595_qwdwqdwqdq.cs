namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdwqdwqdq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Features", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Features", "Description", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Features", "Description", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Features", "Title", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
