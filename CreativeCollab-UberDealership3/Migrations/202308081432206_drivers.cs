namespace CreativeCollab_UberDealership3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drivers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverID = c.Int(nullable: false, identity: true),
                        DriverFirstName = c.String(),
                        DriverLastName = c.String(),
                    })
                .PrimaryKey(t => t.DriverID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
        }
    }
}
