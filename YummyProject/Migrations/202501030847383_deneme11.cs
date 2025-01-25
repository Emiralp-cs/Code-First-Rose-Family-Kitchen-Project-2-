namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "ImageUrl", c => c.String());
            AlterColumn("dbo.Abouts", "ImageUrl2", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "ImageUrl2", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Abouts", "ImageUrl", c => c.String(nullable: false, maxLength: 500));
        }
    }
}
