using System.Data.Entity;
using Investment.Domain;

namespace Investment.Persistance
{
    public class InvestmentContext : DbContext
    {
        public DbSet<Domain.Investment> Invesments { get; set; }

        public DbSet<Domain.Distribution> Distributions { get; set; }
    }
}
