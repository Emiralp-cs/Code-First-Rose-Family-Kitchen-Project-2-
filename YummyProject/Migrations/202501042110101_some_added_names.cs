namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class some_added_names : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chefs", "ChefName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chefs", "ChefName");
        }
    }
}
