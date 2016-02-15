namespace Investment.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
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
                        CurrencyCode = c.String(),
                        CommissionPaidWhenBought = c.Double(nullable: false),
                        CurrentPrice = c.Double(nullable: false),
                        TotalDistributionSinceBought = c.Double(nullable: false),
                        ComissionPaidWhenSell = c.Double(nullable: false),
                        TotalWhenBought = c.Double(),
                        TotalNow = c.Double(),
                        DifferencePercentage = c.Double(),
                        DaysSinceBought = c.Int(),
                        DifferenceMoney = c.Double(),
                        PercentageOfInvestment = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Date = c.DateTime(nullable: false),
                        Open = c.Double(nullable: false),
                        Close = c.Double(nullable: false),
                        Low = c.Double(nullable: false),
                        High = c.Double(nullable: false),
                        Share_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shares", t => t.Share_Id)
                .Index(t => t.Share_Id);
            
            CreateTable(
                "dbo.Shares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prices", "Share_Id", "dbo.Shares");
            DropIndex("dbo.Prices", new[] { "Share_Id" });
            DropTable("dbo.Shares");
            DropTable("dbo.Prices");
            DropTable("dbo.Positions");
            DropTable("dbo.Distributions");
        }
    }
}
