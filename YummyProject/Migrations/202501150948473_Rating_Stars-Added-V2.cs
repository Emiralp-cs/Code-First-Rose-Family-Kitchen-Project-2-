namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating_StarsAddedV2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rating_Stars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rating_Stars_Counter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rating_Stars");
        }
    }
}
