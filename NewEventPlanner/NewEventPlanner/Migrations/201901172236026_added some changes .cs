namespace NewEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedsomechanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Businesses", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Businesses", "Quantity", c => c.Int(nullable: false));
        }
    }
}
