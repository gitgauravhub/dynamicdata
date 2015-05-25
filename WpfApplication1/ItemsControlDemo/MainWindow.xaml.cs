using System;
using System.Collections.Generic;
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

namespace ItemsControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ItemsControlDemoContext currentContext = new ItemsControlDemoContext();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = currentContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            currentContext.People.Add(new Person() { Name="King", Age=27});
            currentContext.People.Add(new Person() { Name = "Queen", Age = 31 });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentContext.People.Remove(currentContext.CurrentPerson);
        }
    }
}
