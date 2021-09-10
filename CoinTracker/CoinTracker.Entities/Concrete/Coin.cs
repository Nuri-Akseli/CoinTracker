using CoinTracker.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinTracker.Entities.Concrete
{
    public class Coin:IEntity
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public decimal current_price { get; set; }
        public double price_change_percentage_1h_in_currency { get; set; }
        public double price_change_percentage_24h_in_currency { get; set; }
        public double price_change_percentage_7d_in_currency { get; set; }
        public int market_cap_rank { get; set; }
        public long market_cap { get; set; }
        public DateTime last_updated { get; set; }
        public string fully_diluted_valuation { get; set; }
        public string total_volume { get; set; }
        public decimal high_24h { get; set; }
        public decimal low_24h { get; set; }
        public double price_change_24h { get; set; }
        public double price_change_percentage_24h { get; set; }
        public string market_cap_change_24h { get; set; }
        public double market_cap_change_percentage_24h { get; set; }
        public double circulating_supply { get; set; }
        public string total_supply { get; set; }
        public string max_supply { get; set; }
        public string ath { get; set; }
        public double ath_change_percentage { get; set; }
        public DateTime ath_date { get; set; }
        public double atl { get; set; }
        public double atl_change_percentage { get; set; }
        public DateTime atl_date { get; set; }
        public object roi { get; set; }
        
    }
}
