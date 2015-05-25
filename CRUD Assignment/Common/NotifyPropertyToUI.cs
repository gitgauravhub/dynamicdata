using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.Common
{
    public abstract class NotifyPropertyToUI
    {
        public void OnPropertyChanged([CallerMemberName] string caller = "", PropertyChangedEventHandler PropertyChanged = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
