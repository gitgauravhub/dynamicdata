using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataConversionDemo
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChange(); }
        }


        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChange(); }
        }

        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }



        public static Employee GetEmployee()
        {
            Employee emp = new Employee { Name = "Tom", Title = "Developer" };
            return emp;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
