﻿namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wqdwqdwqdwqdwqdwqdwqdwqdwq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConInfoes");
        }
    }
}
