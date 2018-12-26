using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace wpf1
{
    class MyModel:INotifyPropertyChanged
    {
        private string _Data = "My Data";
        public string Data
        {
            get { return _Data; }
            set {
                if (_Data == value) return;
                _Data = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Data"));
                 }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
