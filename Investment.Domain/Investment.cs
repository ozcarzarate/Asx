using System;

namespace Investment.Domain
{
    public class Investment
    {
        public string Code { get; set; }
        public DateTime DateWhenBought { get; set; }
        public int Quantity { get; set; }
        public double PceWhenBought { get; set; }
        public double CommissionPaidWhenBought { get; set; }
        public double CurrentPrice { get; set; }
        public double TotalDistributionSinceBought { get; set; }
        public double ComissionPaidWhenSell { get; set; }
    }
}
