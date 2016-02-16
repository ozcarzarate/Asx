using System.Threading.Tasks;

namespace Investment.Domain.Interfaces
{
    public interface IScreenScrapper
    {
        Task DoWork(string Url);
        Task<double> GetYahooPrice(string code);
    }
}