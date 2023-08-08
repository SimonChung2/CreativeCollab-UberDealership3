namespace CreativeCollab_UberDealership3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Mileage = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
