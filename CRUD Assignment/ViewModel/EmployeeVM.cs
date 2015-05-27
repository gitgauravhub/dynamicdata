using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApplication2.Common;
using WpfApplication2.Model;
using WpfApplication2.Repository;

namespace WpfApplication2.ViewModel
{
    public class EmployeeVM : INotifyPropertyChanged
    {
        Employee objEmpoyee;
        private Employee objEmployee = new Employee();

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        public EmployeeVM()
        {
            objEmployee = new Employee();
            SaveCommand = new RelayCommand(DoSave);
            UpdateCommand = new RelayCommand(DoUpdate);
            DeleteCommand = new RelayCommand(DoDelete);

        }

        private void EmployeeFromUI()
        {
            objEmpoyee = new Employee();
            objEmpoyee.Name = txtName;
            objEmpoyee.EmailAddress = txtEmailAddress;
            objEmpoyee.Salary = txtSalary;
        }

        private void DoSave(object obj)
        {
            EmployeeFromUI();
            EmployeeRepository.InsertEmployee(objEmpoyee);
            OnPropertyChanged("Employees");
        }

        private void DoDelete(object obj)
        {
            EmployeeFromUI();
            EmployeeRepository.DeleteEmployee(objEmpoyee);
            OnPropertyChanged("Employees");
        }

        private void DoUpdate(object obj)
        {
            EmployeeFromUI();
            EmployeeRepository.UpdateEmployee(objEmpoyee);
            OnPropertyChanged("Employees");
        }

        public string txtName
        {
            get { return objEmployee.Name; }
            set { objEmployee.Name = value; OnPropertyChanged(); }
        }

        public string txtEmailAddress
        {
            get { return objEmployee.EmailAddress; }
            set { objEmployee.EmailAddress = value; OnPropertyChanged(); }
        }

        public decimal txtSalary
        {
            get { return objEmployee.Salary; }
            set { objEmployee.Salary = value; OnPropertyChanged(); }
        }

        private Employee _selectedEmployee;

        public Employee SelectEmployee
        {
            get
            {
                return _selectedEmployee;
            }
            set
            {
                _selectedEmployee = value;
                if (_selectedEmployee != null)
                {
                    txtName = _selectedEmployee.Name;
                    txtEmailAddress = _selectedEmployee.EmailAddress;
                    txtSalary = _selectedEmployee.Salary;
                }
            }
        }

        ObservableCollection<EmployeeVM> _Employee;

        public ObservableCollection<EmployeeVM> Employees
        {
            get
            {
                var data = new List<Employee>(EmployeeRepository.GetEmployeeFromDatabase());
                if (data.Count > 0)
                {
                    _Employee = new ObservableCollection<EmployeeVM>();
                    foreach (var item in data)
                    {
                        _Employee.Add(new EmployeeVM() { txtEmailAddress = item.EmailAddress, txtName = item.Name, txtSalary = item.Salary });
                    }
                }
                return _Employee;
            }
            set
            {
                _Employee = value;
                // OnPropertyChanged();
            }
        }


        Employee _employee;
        public Employee employee
        {
            get
            {
                _employee = new Employee();
                return _employee;
            }
            set
            {
                _employee = value;
                txtSalary = value.Salary;
                txtEmailAddress = value.EmailAddress;
                txtName = value.Name;
                OnPropertyChanged("employee");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
