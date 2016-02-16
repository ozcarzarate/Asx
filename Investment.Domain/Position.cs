using System;

namespace Investment.Domain
{
    public class Position
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public DateTime DateWhenBought { get; set; }
        public int Quantity { get; set; }
        public double PriceWhenBought { get; set; }
        public string CurrencyCode { get; set; }
        public double CommissionPaidWhenBought { get; set; }
        public double CurrentPrice { get; set; }
        public double TotalDistributionSinceBought { get; set; }
        public double ComissionPaidWhenSell { get; set; }
    }
}
