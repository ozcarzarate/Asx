using System;

namespace Investment.Domain
{
    public class Distribution
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public DateTime DateOfDistribution { get; set; }
        public double CentPerShare { get; set; }
    }
}
