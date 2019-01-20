namespace NewEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class again : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "BookingDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Businesses", "BookingDate");
        }
    }
}
