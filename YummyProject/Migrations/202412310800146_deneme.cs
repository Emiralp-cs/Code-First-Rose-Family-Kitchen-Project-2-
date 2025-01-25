namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Admins", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "Email", c => c.String());
        }
    }
}
