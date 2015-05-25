using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    public class Employee : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(); }
        }

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }

        private bool _wasReelected;

        public bool WasReelected
        {
            get { return _wasReelected; }
            set { _wasReelected = value; RaisePropertyChanged(); }
        }

        private Party _affiliation;

        public Party Affiliation
        {
            get { return _affiliation; }
            set { _affiliation = value; RaisePropertyChanged(); }
        }

        public static ObservableCollection<Employee> GetEmployee()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name = "Washington", Title = "Presedent 1", WasReelected = true, Affiliation = Party.Independent });
            employees.Add(new Employee() { Name = "Adams", Title = "Presedent 2", WasReelected = false, Affiliation = Party.Federalist });
            employees.Add(new Employee() { Name = "Jefferson", Title = "Presedent 3", WasReelected = true, Affiliation = Party.DemocratRepublican });
            employees.Add(new Employee() { Name = "Madison", Title = "Presedent 4", WasReelected = true, Affiliation = Party.DemocratRepublican });
            employees.Add(new Employee() { Name = "Monroe", Title = "Presedent 5", WasReelected = true, Affiliation = Party.DemocratRepublican });
            return employees;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public enum Party
    {
        Independent,
        Federalist,
        DemocratRepublican
    }
}
