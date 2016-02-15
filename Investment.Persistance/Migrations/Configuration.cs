namespace Investment.Persistance.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Investment.Persistance.InvestmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Investment.Persistance.InvestmentContext context)
        {
            context.Positions.AddOrUpdate(
                new Domain.Position { DateWhenBought = new DateTime(2015, 08, 19), Key = "CBA", Quantity = 100, PriceWhenBought = 77.08, CommissionPaidWhenBought = 19.95, TotalDistributionSinceBought = 0, CurrencyCode="AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 08, 25), Key = "ALI", Quantity = 1000, PriceWhenBought = 1.89, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 08, 25), Key = "AFI", Quantity = 800, PriceWhenBought = 5.93, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 08, 27), Key = "STW", Quantity = 100, PriceWhenBought = 49.35, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 1.19, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 11, 05), Key = "IOO", Quantity = 50, PriceWhenBought = 107.32, CommissionPaidWhenBought = 19.95, TotalDistributionSinceBought = 0.11, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 12, 01), Key = "VAP", Quantity = 45, PriceWhenBought = 74.56, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 1.19, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 11, 05), Key = "DCG", Quantity = 500, PriceWhenBought = 1.00, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 11, 12), Key = "AFI", Quantity = 2723, PriceWhenBought = 5.51, CommissionPaidWhenBought = 0.00, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 12, 01), Key = "S32", Quantity = 2000, PriceWhenBought = 1.19, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 12, 10), Key = "S32", Quantity = 2000, PriceWhenBought = 1.01, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 12, 14), Key = "BHP", Quantity = 200, PriceWhenBought = 16.69, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 12, 18), Key = "NDQ", Quantity = 200, PriceWhenBought = 11.67, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 0.04, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 01, 04), Key = "IOO", Quantity = 50, PriceWhenBought = 100.21, CommissionPaidWhenBought = 19.95, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 01, 16), Key = "AAPL", Quantity = 100, PriceWhenBought = 141.70, CommissionPaidWhenBought = 19.95, TotalDistributionSinceBought = 0, CurrencyCode = "USD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 01, 11), Key = "STW", Quantity = 2, PriceWhenBought = 44.56, CommissionPaidWhenBought = 0.00, TotalDistributionSinceBought = 1.19, CurrencyCode = "AUD" },
                new Domain.Position { DateWhenBought = new DateTime(2015, 08, 19), Key = "ANN", Quantity = 300, PriceWhenBought = 16.00, CommissionPaidWhenBought = 14.95, TotalDistributionSinceBought = 0, CurrencyCode = "AUD" }
                );
        }
    }
}
