namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating_Stars_Selectablepropadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rating_Stars", "Rating_Stars_Selectable", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rating_Stars", "Rating_Stars_Selectable");
        }
    }
}
