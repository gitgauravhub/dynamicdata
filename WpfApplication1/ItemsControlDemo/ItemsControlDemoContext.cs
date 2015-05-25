using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ItemsControlDemo
{
    public class ItemsControlDemoContext : INotifyPropertyChanged
    {
        public ItemsControlDemoContext()
        {
            People = CreateAndReturnPeople();
        }

        private ObservableCollection<Person> CreateAndReturnPeople()
        {
            return new ObservableCollection<Person>()
            {
                new Person(){Name="Kevin",Age=33},
                new Person(){Name="Sven",Age=28},
                new Person(){Name="Tom",Age=33}
            };
        }

        private ObservableCollection<Person> _people { get; set; }
        public ObservableCollection<Person> People
        {
            get
            {
                return _people;
            }
            set
            {
                if (value != _people)
                {
                    _people = value;
                    RaisePropertyChanged("People");
                }
            }
        }

        private Person _currentPerson;

        public Person CurrentPerson
        {
            get { return _currentPerson; }
            set { _currentPerson = value; RaisePropertyChanged("CurrentPerson"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
