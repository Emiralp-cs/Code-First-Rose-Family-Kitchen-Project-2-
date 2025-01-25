namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ChefSocialLogoes", "ChefSocialId", "dbo.ChefSocials");
            DropIndex("dbo.ChefSocialLogoes", new[] { "ChefSocialId" });
            RenameColumn(table: "dbo.ChefSocialLogoes", name: "ChefSocialId", newName: "ChefSocial_ChefSocialId");
            AlterColumn("dbo.ChefSocialLogoes", "ChefSocial_ChefSocialId", c => c.Int());
            CreateIndex("dbo.ChefSocialLogoes", "ChefSocial_ChefSocialId");
            AddForeignKey("dbo.ChefSocialLogoes", "ChefSocial_ChefSocialId", "dbo.ChefSocials", "ChefSocialId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChefSocialLogoes", "ChefSocial_ChefSocialId", "dbo.ChefSocials");
            DropIndex("dbo.ChefSocialLogoes", new[] { "ChefSocial_ChefSocialId" });
            AlterColumn("dbo.ChefSocialLogoes", "ChefSocial_ChefSocialId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.ChefSocialLogoes", name: "ChefSocial_ChefSocialId", newName: "ChefSocialId");
            CreateIndex("dbo.ChefSocialLogoes", "ChefSocialId");
            AddForeignKey("dbo.ChefSocialLogoes", "ChefSocialId", "dbo.ChefSocials", "ChefSocialId", cascadeDelete: true);
        }
    }
}
