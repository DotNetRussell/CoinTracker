using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CoinTracker.Models
{
    public class CoinMarketCapRequestModel : ModelBase
    {
        [JsonProperty("status")]
        public StatusModel Status { get; set; }
        [JsonProperty("data")]
        public List<CoinModel> Data { get; set; }
    }
}
