namespace CreativeCollab_UberDealership3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ridecardriver : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rides", "CarID", c => c.Int(nullable: false));
            AddColumn("dbo.Rides", "DriverID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rides", "DriverID");
            DropColumn("dbo.Rides", "CarID");
        }
    }
}
