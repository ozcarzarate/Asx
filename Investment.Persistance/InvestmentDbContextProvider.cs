using System;
using System.Data.Entity;

namespace Investment.Persistance
{
    public class InvestmentDbContextProvider : IDbContextProvider, IDisposable
    {
        private DbContext _context;

        public DbContext GetDbContext()
        {
            if (_context == null)
            {
                _context = new InvestmentContext();
            }
            return _context;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool all)
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
