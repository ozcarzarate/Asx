using System;

namespace Investment.Domain
{
    public class Distribution
    {
        public string Code { get; set; }
        public DateTime DateOfDistribution { get; set; }
        public double CentPerShare { get; set; }
    }
}
