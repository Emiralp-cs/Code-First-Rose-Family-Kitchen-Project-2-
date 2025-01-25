namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId", "dbo.ChefSocials");
            DropIndex("dbo.SocialMediaLogoes", new[] { "ChefSocial_ChefSocialId" });
            DropColumn("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId", c => c.Int());
            CreateIndex("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId");
            AddForeignKey("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId", "dbo.ChefSocials", "ChefSocialId");
        }
    }
}
