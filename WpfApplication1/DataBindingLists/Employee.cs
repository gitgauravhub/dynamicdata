using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
namespace DataBindingLists
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

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public static ObservableCollection<Employee> GetEmployee()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name="Washington", Title="Presedent 1"});
            employees.Add(new Employee() { Name = "Adams", Title = "Presedent 2" });
            employees.Add(new Employee() { Name = "Jefferson", Title = "Presedent 3" });
            employees.Add(new Employee() { Name = "Madison", Title = "Presedent 4" });
            employees.Add(new Employee() { Name = "Monroe", Title = "Presedent 5" });
            return employees;
        }
    }
}
