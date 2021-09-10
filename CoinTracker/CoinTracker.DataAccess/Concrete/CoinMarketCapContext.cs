using CoinTracker.Core.DataAccess;
using CoinTracker.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace CoinTracker.DataAccess.Concrete
{
    public class CoinMarketCapContext : IJsonRepository<Coin>, IDisposable
    {
        private string URL = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=100&page=1&sparkline=false&price_change_percentage=1h%2C24h%2C7d";
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<Coin> GetList()
        {

            using (var webClient = new System.Net.WebClient())
            {
                try
                {
                    var json = webClient.DownloadString(URL);

                    return JsonConvert.DeserializeObject<List<Coin>>(json);
                }
                catch (Exception)
                {
                    return null;
                }
                
            }
        }
    }
}
