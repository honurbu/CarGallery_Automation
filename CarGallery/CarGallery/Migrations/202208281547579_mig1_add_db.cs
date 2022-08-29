namespace CarGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1_add_db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        CarBrand = c.String(),
                        CarModel = c.String(),
                        CarYear = c.String(),
                        CarColor = c.String(),
                        CarPurchasePrice = c.Int(nullable: false),
                        CarProfit = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.CarID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
