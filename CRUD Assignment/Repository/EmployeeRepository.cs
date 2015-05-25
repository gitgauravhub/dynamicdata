using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication2.Model;

namespace WpfApplication2.Repository
{
    public class EmployeeRepository
    {
        static List<Employee> MainList = new List<Employee>();
        public static List<Employee> GetEmployeeFromDatabase()
        {
            return MainList;
        }

        internal static void InsertEmployee(Employee employee)
        {
            MainList.Add(employee);
        }

        internal static void UpdateEmployee(Employee employee)
        {
            if (MainList.Count > 0)
            {
                var data = MainList.Where(x => (x.Name == employee.Name && x.EmailAddress == employee.EmailAddress)).FirstOrDefault();
                if (data != null)
                {
                    data.Name = employee.Name;
                    data.EmailAddress = employee.EmailAddress;
                    data.Salary = employee.Salary;
                }
            }
        }

        internal static void DeleteEmployee(Employee employee)
        {

            var itemToRemove = MainList.FirstOrDefault(r => r.EmailAddress == employee.EmailAddress);
            //resultList.Remove(itemToRemove);

            MainList.Remove(itemToRemove);
        }
    }
}
