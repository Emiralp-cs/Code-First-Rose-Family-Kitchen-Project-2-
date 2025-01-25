namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMediaLogoes",
                c => new
                    {
                        SocialMediaLogoId = c.Int(nullable: false, identity: true),
                        SocialMediaLogos = c.String(),
                        SocialMediaLogoName = c.String(),
                        ChefSocialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaLogoId)
                .ForeignKey("dbo.ChefSocials", t => t.ChefSocialId, cascadeDelete: true)
                .Index(t => t.ChefSocialId);
            
            DropColumn("dbo.ChefSocials", "SocialMediaLogo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ChefSocials", "SocialMediaLogo", c => c.String());
            DropForeignKey("dbo.SocialMediaLogoes", "ChefSocialId", "dbo.ChefSocials");
            DropIndex("dbo.SocialMediaLogoes", new[] { "ChefSocialId" });
            DropTable("dbo.SocialMediaLogoes");
        }
    }
}
