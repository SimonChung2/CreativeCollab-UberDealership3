namespace CreativeCollab_UberDealership3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drivercar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "CarID", c => c.Int(nullable: false));
            CreateIndex("dbo.Drivers", "CarID");
            AddForeignKey("dbo.Drivers", "CarID", "dbo.Cars", "CarID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drivers", "CarID", "dbo.Cars");
            DropIndex("dbo.Drivers", new[] { "CarID" });
            DropColumn("dbo.Drivers", "CarID");
        }
    }
}
