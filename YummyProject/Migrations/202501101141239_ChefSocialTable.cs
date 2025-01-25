namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChefSocialTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChefSocialLogoes",
                c => new
                    {
                        ChefSocialLogoId = c.Int(nullable: false, identity: true),
                        LogoName = c.String(),
                        ChefSocialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChefSocialLogoId)
                .ForeignKey("dbo.ChefSocials", t => t.ChefSocialId, cascadeDelete: true)
                .Index(t => t.ChefSocialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChefSocialLogoes", "ChefSocialId", "dbo.ChefSocials");
            DropIndex("dbo.ChefSocialLogoes", new[] { "ChefSocialId" });
            DropTable("dbo.ChefSocialLogoes");
        }
    }
}
