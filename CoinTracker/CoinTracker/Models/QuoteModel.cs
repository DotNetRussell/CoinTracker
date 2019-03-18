using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinTracker.Models
{
    public class QuoteModel : ModelBase
    {
        [JsonProperty("USD")]
        public USDModel USD { get; set; }
    }
}
