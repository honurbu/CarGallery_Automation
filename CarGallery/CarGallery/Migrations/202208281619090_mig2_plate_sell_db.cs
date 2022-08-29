namespace CarGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2_plate_sell_db : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarSellPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "CarPlate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "CarPlate");
            DropColumn("dbo.Cars", "CarSellPrice");
        }
    }
}
