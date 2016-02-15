using Investment.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Investment.Persistance.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T>,  IDisposable
    {
        private readonly IDbContextProvider _dbContextProvider;
        protected InvestmentContext Context
        {
            get { return _dbContextProvider.GetDbContext() as InvestmentContext; }
        }

        public BaseRepository(IDbContextProvider dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool all)
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public abstract IEnumerable<T> Get();
        public abstract T GetByKey(string Key);
        public abstract void AddOrUpdate(T element);
        public abstract void Delete(T element);
    }
}
