using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinTracker.Models
{
    public class CoinModel : ModelBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("circulating_supply")]
        public double CirculatingSupply { get; set; }
        [JsonProperty("total_supply")]
        public double TotalSupply { get; set; }
        [JsonProperty("max_supply")]
        public long? MaxSupply { get; set; }
        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }
        [JsonProperty("num_market_pairs")]
        public int NumMarketPairs { get; set; }
        [JsonProperty("tags")]
        public List<object> Tags { get; set; }
        [JsonProperty("platform")]
        public PlatformModel Platform { get; set; }
        [JsonProperty("cmc_rank")]
        public int CmcRank { get; set; }
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
        [JsonProperty("quote")]
        public QuoteModel CurrentQuote { get; set; }
    }
}
