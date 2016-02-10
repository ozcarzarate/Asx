using System;

namespace Investment.Domain
{
    public class Investment
    {
        
        public double CommissionPaidWhenBought { get; set; }
        public double CurrentPrice { get; set; }
        public double TotalDistributionSinceBought { get; set; }
        public double ComissionPaidWhenSell { get; set; }
    }
}
