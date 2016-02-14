namespace Investment.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Distributions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        DateOfDistribution = c.DateTime(nullable: false),
                        CentPerShare = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        DateWhenBought = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PriceWhenBought = c.Double(nullable: false),
                        CommissionPaidWhenBought = c.Double(nullable: false),
                        CurrentPrice = c.Double(nullable: false),
                        TotalDistributionSinceBought = c.Double(nullable: false),
                        ComissionPaidWhenSell = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Positions");
            DropTable("dbo.Distributions");
        }
    }
}
