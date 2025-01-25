namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdqdqw : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConInfoes", "Address", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.ConInfoes", "Email", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.ConInfoes", "PhoneNumber", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.ConInfoes", "OpeningHours", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConInfoes", "OpeningHours");
            DropColumn("dbo.ConInfoes", "PhoneNumber");
            DropColumn("dbo.ConInfoes", "Email");
            DropColumn("dbo.ConInfoes", "Address");
        }
    }
}
