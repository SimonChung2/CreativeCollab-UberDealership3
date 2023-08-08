namespace CreativeCollab_UberDealership3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        ModelName = c.String(),
                        Make = c.String(),
                    })
                .PrimaryKey(t => t.ModelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarModels");
        }
    }
}
