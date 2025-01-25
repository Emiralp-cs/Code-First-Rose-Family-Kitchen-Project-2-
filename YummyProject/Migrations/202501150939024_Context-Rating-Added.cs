namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextRatingAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingID = c.String(nullable: false, maxLength: 128),
                        RatingCounter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RatingID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ratings");
        }
    }
}
