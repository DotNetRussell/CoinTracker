using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CoinTracker.Models
{
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String propName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
