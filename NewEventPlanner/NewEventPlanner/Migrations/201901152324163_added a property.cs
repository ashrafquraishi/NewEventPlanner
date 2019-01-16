namespace NewEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedaproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Businesses", "Phone");
        }
    }
}
