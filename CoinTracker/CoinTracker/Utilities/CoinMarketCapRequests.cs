using CoinTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace CoinTracker.Utilities
{
    public static class CoinMarketCapRequests
    {
        public static string ApiKey { get; set; }
        public static void GetTop5Coins_DEMO_DATA(Action<CoinMarketCapRequestModel> callback)
        {
           callback(JsonConvert.DeserializeObject<CoinMarketCapRequestModel>(DemoData.DemoData.DemoListings5));
        }

        private static void GetCoins(Action<CoinMarketCapRequestModel> callback, int coinCount)
        {
            using (WebClient client = new WebClient())
            {
                var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

                string API_KEY = ApiKey;

                var queryString = HttpUtility.ParseQueryString(string.Empty);
                queryString["start"] = "1";
                queryString["limit"] = coinCount.ToString();
                queryString["convert"] = "USD";

                URL.Query = queryString.ToString();

                client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
                client.Headers.Add("Accepts", "application/json");


                client.DownloadStringCompleted += ((s, a) =>
                {
                    try
                    {
                        callback(JsonConvert.DeserializeObject<CoinMarketCapRequestModel>(a.Result));
                    }
                    catch (Exception error)
                    {

                    }
                });

                client.DownloadStringAsync(URL.Uri);
            }
        }

        public static void GetTop10Coins(Action<CoinMarketCapRequestModel> callback)
        {
            GetCoins(callback, 10);
        }

        public static void GetTop100Coins(Action<CoinMarketCapRequestModel> callback)
        {
            GetCoins(callback, 100);
        }
    }
}
