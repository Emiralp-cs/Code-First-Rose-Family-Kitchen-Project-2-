namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dwqdqwdwqdwqd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SocialMediaLogoes", "SocialMediaLogos", c => c.String(maxLength: 20));
            AlterColumn("dbo.SocialMediaLogoes", "SocialMediaLogoName", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SocialMediaLogoes", "SocialMediaLogoName", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialMediaLogoes", "SocialMediaLogos", c => c.String(maxLength: 3));
        }
    }
}
