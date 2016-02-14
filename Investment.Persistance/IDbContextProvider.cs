using System.Data.Entity;

namespace Investment.Persistance
{
    public interface IDbContextProvider
    {
        DbContext GetDbContext();
    }
}
