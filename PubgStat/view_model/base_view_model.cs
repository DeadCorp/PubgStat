using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PubgStat.view_model {
public    abstract class base_view_model : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotyfyPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
