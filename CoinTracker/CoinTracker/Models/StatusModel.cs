using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoinTracker.Models
{
    public class StatusModel : ModelBase
    {
        [JsonProperty("timestamp")]
        public DateTime RequestTimeStamp { get; set; }
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }
        [JsonProperty("error_message")]
        public object ErrorMessage { get; set; }
        [JsonProperty("elapsed")]
        public int Elapsed { get; set; }
        [JsonProperty("credit_count")]
        public int CreditCount { get; set; }
    }
}
