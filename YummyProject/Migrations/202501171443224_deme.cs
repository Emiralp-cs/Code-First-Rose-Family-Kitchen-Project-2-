namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "BookingDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "BookingDate", c => c.String(nullable: false));
        }
    }
}
