using CoinTracker.Models;
using CoinTracker.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace CoinTracker.ViewModels
{
    public class MasterViewModel : ViewModelBase
    {
        private string _apiKey;

        public string ApiKey
        {
            get { return _apiKey; }
            set { _apiKey = value; Utilities.CoinMarketCapRequests.ApiKey = value; }
        }

        public ICommand Top10Command { get; set; }
        public ICommand Top100Command { get; set; }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged("IsBusy"); }
        }


        public ObservableCollection<CoinModel> Coins { get; set; }
        public MasterViewModel()
        {
            Coins = new ObservableCollection<CoinModel>();

            Top10Command = new CommandHandler(OnTop10CommandExecuted, null);
            Top100Command = new CommandHandler(OnTop100CommandExecuted, null);
        }

        private void OnTop10CommandExecuted()
        {
            IsBusy = true;
            Coins.Clear();
            Utilities.CoinMarketCapRequests.GetTop10Coins((results) =>
            {
                foreach (CoinModel coin in results.Data)
                {
                    Coins.Add(coin);
                }
                IsBusy = false;
            });
        }

        private void OnTop100CommandExecuted()
        {
            IsBusy = true;
            Coins.Clear();
            Utilities.CoinMarketCapRequests.GetTop100Coins((results) =>
            {
                foreach (CoinModel coin in results.Data)
                {
                    Coins.Add(coin);
                }
                IsBusy = false;
            });
        }
    }
}
