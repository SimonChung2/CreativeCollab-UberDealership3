namespace CreativeCollab_UberDealership3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carcarmodeldealer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "ModelID", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "DealerID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "ModelID");
            CreateIndex("dbo.Cars", "DealerID");
            AddForeignKey("dbo.Cars", "ModelID", "dbo.CarModels", "ModelID", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "DealerID", "dbo.Dealers", "DealerID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "DealerID", "dbo.Dealers");
            DropForeignKey("dbo.Cars", "ModelID", "dbo.CarModels");
            DropIndex("dbo.Cars", new[] { "DealerID" });
            DropIndex("dbo.Cars", new[] { "ModelID" });
            DropColumn("dbo.Cars", "DealerID");
            DropColumn("dbo.Cars", "ModelID");
        }
    }
}
