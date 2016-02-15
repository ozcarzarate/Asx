using System;

namespace Investment.Domain
{
    public class Price
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
    }
}