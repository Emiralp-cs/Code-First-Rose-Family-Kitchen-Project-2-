namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fwefqw : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SocialMediaLogoes", "ChefSocialId", "dbo.ChefSocials");
            DropIndex("dbo.SocialMediaLogoes", new[] { "ChefSocialId" });
            RenameColumn(table: "dbo.SocialMediaLogoes", name: "ChefSocialId", newName: "ChefSocial_ChefSocialId");
            AlterColumn("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId", c => c.Int());
            CreateIndex("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId");
            AddForeignKey("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId", "dbo.ChefSocials", "ChefSocialId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId", "dbo.ChefSocials");
            DropIndex("dbo.SocialMediaLogoes", new[] { "ChefSocial_ChefSocialId" });
            AlterColumn("dbo.SocialMediaLogoes", "ChefSocial_ChefSocialId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.SocialMediaLogoes", name: "ChefSocial_ChefSocialId", newName: "ChefSocialId");
            CreateIndex("dbo.SocialMediaLogoes", "ChefSocialId");
            AddForeignKey("dbo.SocialMediaLogoes", "ChefSocialId", "dbo.ChefSocials", "ChefSocialId", cascadeDelete: true);
        }
    }
}
