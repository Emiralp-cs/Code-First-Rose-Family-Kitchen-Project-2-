namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wqdwqd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactInfoes", "Email", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactInfoes", "Email");
        }
    }
}
