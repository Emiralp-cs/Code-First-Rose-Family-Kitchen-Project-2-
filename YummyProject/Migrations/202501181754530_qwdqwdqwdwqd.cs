namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdqwdqwdwqd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Icon", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "Icon", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
