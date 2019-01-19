namespace NewEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SecurityAgencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecurityAgencyName = c.String(),
                        NumberOfPeople = c.Int(nullable: false),
                        Charge = c.Double(nullable: false),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SecurityAgencies", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.SecurityAgencies", new[] { "ApplicationUserId" });
            DropTable("dbo.SecurityAgencies");
        }
    }
}
