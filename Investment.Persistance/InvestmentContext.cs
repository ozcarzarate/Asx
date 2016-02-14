using System.Data.Entity;
using Investment.Domain;

namespace Investment.Persistance
{
    public class InvestmentContext : DbContext
    {
        static InvestmentContext()
        {
            //TODO decide environments
            Database.SetInitializer<InvestmentContext>(new CreateDatabaseIfNotExists<InvestmentContext>());
        }

        public InvestmentContext() : base("Name=Investments"){}

        public DbSet<Position> Positions { get; set; }

        public DbSet<Distribution> Distributions { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Domain.Investment>().HasKey(i => new
        //    {
        //        i.
        //    });

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
