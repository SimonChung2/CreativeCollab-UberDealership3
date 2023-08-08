namespace CreativeCollab_UberDealership3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dealers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dealers",
                c => new
                    {
                        DealerID = c.Int(nullable: false, identity: true),
                        DealerName = c.String(),
                    })
                .PrimaryKey(t => t.DealerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dealers");
        }
    }
}
