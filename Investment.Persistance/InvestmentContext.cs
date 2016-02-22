﻿using System.Data.Entity;
using Investment.Domain;

namespace Investment.Persistance
{
    public class InvestmentContext : DbContext
    {
        static InvestmentContext()
        {
            //TODO decide what to use according to environments 
            //DropCreateDatabaseIfModelChanges<TContext>, 
            //DropCreateDatabaseAlways<TContext>, 
            //CreateDatabaseIfNotExists<TContext>)
#if DEBUG
            Database.SetInitializer<InvestmentContext>(new CreateDatabaseIfNotExists<InvestmentContext>());
#else
            Database.SetInitializer<InvestmentContext>(null);
#endif
        }

        public InvestmentContext() : base("Name=Investments"){}

        public DbSet<Position> Positions { get; set; }
        public DbSet<Distribution> Distributions { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<Price> Prices { get; set; }

        
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
