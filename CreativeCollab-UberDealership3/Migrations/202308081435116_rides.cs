namespace CreativeCollab_UberDealership3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rides : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rides",
                c => new
                    {
                        RideId = c.Int(nullable: false, identity: true),
                        RideName = c.String(),
                        StartLocation = c.String(),
                        EndLocation = c.String(),
                    })
                .PrimaryKey(t => t.RideId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rides");
        }
    }
}
