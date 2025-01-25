namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "BookingDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "BookingDate", c => c.DateTime(nullable: false));
        }
    }
}
