namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedratingformistake : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Ratings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingId = c.Int(nullable: false, identity: true),
                        RatingCounter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RatingId);
            
        }
    }
}
