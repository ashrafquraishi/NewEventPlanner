namespace NewEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedcaterersdetails : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Businesses", "CaterersName");
            DropColumn("dbo.Businesses", "Item1");
            DropColumn("dbo.Businesses", "Item2");
            DropColumn("dbo.Businesses", "Item3");
            DropColumn("dbo.Businesses", "Item4");
            DropColumn("dbo.Businesses", "Customize");
            DropColumn("dbo.Businesses", "Description");
            DropColumn("dbo.Businesses", "MenuPrice");
            DropColumn("dbo.Businesses", "SecurityAgencyName");
            DropColumn("dbo.Businesses", "NumberOfPeople");
            DropColumn("dbo.Businesses", "Charge");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Businesses", "Charge", c => c.Double(nullable: false));
            AddColumn("dbo.Businesses", "NumberOfPeople", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "SecurityAgencyName", c => c.String());
            AddColumn("dbo.Businesses", "MenuPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Businesses", "Description", c => c.String());
            AddColumn("dbo.Businesses", "Customize", c => c.String());
            AddColumn("dbo.Businesses", "Item4", c => c.String());
            AddColumn("dbo.Businesses", "Item3", c => c.String());
            AddColumn("dbo.Businesses", "Item2", c => c.String());
            AddColumn("dbo.Businesses", "Item1", c => c.String());
            AddColumn("dbo.Businesses", "CaterersName", c => c.String());
        }
    }
}
