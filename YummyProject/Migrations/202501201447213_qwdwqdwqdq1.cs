namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdwqdwqdq1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "Description", c => c.String(nullable: false, maxLength: 400));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "Description", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
