namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwdwqdqwd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhotoGalleries", "ImageUrl", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhotoGalleries", "ImageUrl", c => c.String());
        }
    }
}
