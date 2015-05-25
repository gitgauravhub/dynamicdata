using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloWorld.Helpers
{
    public class FillRectangleColor : INotifyPropertyChanged
    {
        private CommandFillRectangle mycommand;
        public FillRectangleColor()
        {
            mycommand = new CommandFillRectangle(this);
        }

        public ICommand CommandFillRectangleAction //Event
        {
            get { return mycommand; }
        }

        public string FillColor { get; set; } // Textbox (Binding)

        public void ChangeColor()
        {
            if (true)
            {
                FillColor = "Green";
            }
            else
            {
                FillColor = "Red";
            }
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("FillColor"));
            }
        }

        public bool isChecked;

        public bool IsChecked
        {
            get
            {
                return isChecked;
            }
            set
            {
                isChecked = value;
                if (isChecked)
                {
                    FillColor = "Green";
                }
                else
                {
                    FillColor = "Red";
                }
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FillColor"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
