using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloWorld.Helpers
{
    public class CommandFillRectangle:ICommand
    {
        private FillRectangleColor fillRectangleColor;

        public CommandFillRectangle(FillRectangleColor fillRectangleColor)
        {
            this.fillRectangleColor = fillRectangleColor;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            fillRectangleColor.ChangeColor();
        }
    }
}
