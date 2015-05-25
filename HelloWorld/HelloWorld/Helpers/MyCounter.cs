using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloWorld.Helpers
{
    public class MyCounter : INotifyPropertyChanged
    {
        private CommandCounter myCommand;

        public MyCounter()
        {
            myCommand = new CommandCounter(this);
        }

        public ICommand CommandCounterAction // Command (Action) btn click or event will bind
        {
            get { return myCommand; }
        }

        public int Counter { get; set; }// Textbox (Binding)
      
        public void Increment()
        {
            Counter++;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Counter"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
