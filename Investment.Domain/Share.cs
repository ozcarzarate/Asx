using System.Collections.Generic;

namespace Investment.Domain
{
    public class Share
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<Price> Prices { get; set; }
    }
}