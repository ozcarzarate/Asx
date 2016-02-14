using HtmlAgilityPack;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace HtmlScrapper
{
    public class ScreenScapper
    {
        public async Task DoWork(string Url)
        {
            var page = new HtmlDocument();
            using (var client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(Url))
            using (HttpContent content = response.Content)
            {
                var result = await content.ReadAsStringAsync();
                page.LoadHtml(result);
                var rows = page.DocumentNode.SelectNodes("//tr[normalize-space(@class) = 'altrow']");
                foreach (var row in rows)
                {
                    Debug.WriteLine(row.ChildNodes[1].InnerText);
                }
                
            }
        }

        public async Task<double> GetYahooPrice(string code)
        {
            var prefix = "https://au.finance.yahoo.com/q?s=";
            var reslt = 0.00;

            var page = new HtmlDocument();
            using (var client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync($"{prefix}{code}"))
            using (HttpContent content = response.Content)
            {
                var result = await content.ReadAsStringAsync();
                page.LoadHtml(result);
                var cell = page.DocumentNode.SelectNodes("//span[normalize-space(@class) = 'time_rtq_ticker']");
                Debug.WriteLine(cell[0].InnerText);
                double.TryParse(cell[0].InnerText, out reslt);
            }
            
            return reslt;
        }
    }
}