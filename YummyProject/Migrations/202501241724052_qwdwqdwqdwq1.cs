﻿namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdwqdwqdwq1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "IsApproved", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "IsApproved", c => c.Boolean(nullable: false));
        }
    }
}
