namespace NewEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateneeded2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "Description", c => c.String());
            AddColumn("dbo.Businesses", "MenuPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Businesses", "SecurityAgencyName", c => c.String());
            AddColumn("dbo.Businesses", "NumberOfPeople", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "Charge", c => c.Double(nullable: false));
            DropColumn("dbo.Businesses", "Discription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Businesses", "Discription", c => c.String());
            DropColumn("dbo.Businesses", "Charge");
            DropColumn("dbo.Businesses", "NumberOfPeople");
            DropColumn("dbo.Businesses", "SecurityAgencyName");
            DropColumn("dbo.Businesses", "MenuPrice");
            DropColumn("dbo.Businesses", "Description");
        }
    }
}
