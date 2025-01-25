namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdwqdwqdwq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Icon", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "Icon", c => c.String(nullable: false));
        }
    }
}
