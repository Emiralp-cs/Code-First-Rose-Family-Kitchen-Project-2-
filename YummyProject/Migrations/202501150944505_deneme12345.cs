namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme12345 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Ratings");
            AlterColumn("dbo.Ratings", "RatingId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Ratings", "RatingId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Ratings");
            AlterColumn("dbo.Ratings", "RatingId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Ratings", "RatingId");
        }
    }
}
