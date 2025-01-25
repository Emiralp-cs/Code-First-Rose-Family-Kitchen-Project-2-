namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ChefSocialLogoes", "ChefSocial_ChefSocialId", "dbo.ChefSocials");
            DropIndex("dbo.ChefSocialLogoes", new[] { "ChefSocial_ChefSocialId" });
            DropTable("dbo.ChefSocialLogoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ChefSocialLogoes",
                c => new
                    {
                        ChefSocialLogoId = c.Int(nullable: false, identity: true),
                        LogoName = c.String(),
                        ChefSocial_ChefSocialId = c.Int(),
                    })
                .PrimaryKey(t => t.ChefSocialLogoId);
            
            CreateIndex("dbo.ChefSocialLogoes", "ChefSocial_ChefSocialId");
            AddForeignKey("dbo.ChefSocialLogoes", "ChefSocial_ChefSocialId", "dbo.ChefSocials", "ChefSocialId");
        }
    }
}
