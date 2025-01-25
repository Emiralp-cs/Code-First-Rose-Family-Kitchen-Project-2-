﻿namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_socialmediatableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        SocialMediaUrl = c.String(),
                        Title = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
        }
    }
}
