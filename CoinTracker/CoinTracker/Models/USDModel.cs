using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinTracker.Models
{
    public class USDModel : ModelBase
    {
        [JsonProperty("price")]
        public double CurrentPrice { get; set; }
        [JsonProperty("volume_24h")]
        public double OneDayVolume { get; set; }
        [JsonProperty("percent_change_1h")]
        public double PercentChangeOneHour { get; set; }
        [JsonProperty("percent_change_24h")]
        public double PercentChangeOneDay { get; set; }
        [JsonProperty("percent_change_7d")]
        public double PercentChangeSevenDays { get; set; }
        [JsonProperty("market_cap")]
        public double MarketCap { get; set; }
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
    }
}
