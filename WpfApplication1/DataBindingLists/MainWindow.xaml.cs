using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingLists
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region ObservableCollection --> When an object is added to or removed from an observable collection, the UI is automatically updated.
        ObservableCollection<Employee> collection;
        public MainWindow()
        {
            InitializeComponent();
            collection = new ObservableCollection<Employee>();
            collection = Employee.GetEmployee();
            DataContext = collection;
        }

        private void changed_DropDownClosed(object sender, EventArgs e)
        {
            collection.Add(new Employee() { Name = "G", Title = "GN" });
        } 
        #endregion

        #region Simple List Example To Check If The UI Updated When We Add/Remove Any Item 
        //List<Employee> collection;
        //public MainWindow()
        //{
        //    InitializeComponent();
        //    collection = new List<Employee>();
        //    collection = Employee.GetEmployee().ToList();
        //    DataContext = collection;
        //}

        //private void changed_DropDownClosed(object sender, EventArgs e)
        //{
        //    //collection.RemoveAt(0);
        //    collection.Add(new Employee() { Name = "G", Title = "GN" });
        //} 
        #endregion
    }
}
