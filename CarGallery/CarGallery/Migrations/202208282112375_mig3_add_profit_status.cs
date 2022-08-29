namespace CarGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3_add_profit_status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "CarProfitStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "CarProfitStatus");
        }
    }
}
