namespace NewEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpropertiesforcaterers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "CaterersName", c => c.String());
            AddColumn("dbo.Businesses", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Businesses", "Item1", c => c.String());
            AddColumn("dbo.Businesses", "Item2", c => c.String());
            AddColumn("dbo.Businesses", "Item3", c => c.String());
            AddColumn("dbo.Businesses", "Item4", c => c.String());
            AddColumn("dbo.Businesses", "Customize", c => c.String());
            AddColumn("dbo.Businesses", "Discription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Businesses", "Discription");
            DropColumn("dbo.Businesses", "Customize");
            DropColumn("dbo.Businesses", "Item4");
            DropColumn("dbo.Businesses", "Item3");
            DropColumn("dbo.Businesses", "Item2");
            DropColumn("dbo.Businesses", "Item1");
            DropColumn("dbo.Businesses", "Quantity");
            DropColumn("dbo.Businesses", "CaterersName");
        }
    }
}
