namespace NewEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class images : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Businesses", "PictureUpload", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Businesses", "PictureUpload");
        }
    }
}
