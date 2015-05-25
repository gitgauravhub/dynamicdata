using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloWorld.Helpers
{
    public class CommandCounter : ICommand
    {
        private MyCounter obj;// WPF UI
        public CommandCounter(MyCounter ob) // WPF Mycounter
        {
            obj = ob;
        }

        public bool CanExecute(object parameter)// When to execute
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;


        public void Execute(object parameter)// What to execute
        {
            obj.Increment();
        }
    }
}
