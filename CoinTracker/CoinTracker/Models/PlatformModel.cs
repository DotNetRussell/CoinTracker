using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinTracker.Models
{
    public class PlatformModel : ModelBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}
