namespace Investment.Domain
{
    public class CurrentPosition : Position
    {
        public double TotalWhenBought { get; set; }
        public double TotalNow { get; set; }
        public double DifferencePercentage { get; set; }
        public int DaysSinceBought { get; set; }
        public double DifferenceMoney { get; set; }
        public double PercentageOfInvestment { get; set; }
    }
}
