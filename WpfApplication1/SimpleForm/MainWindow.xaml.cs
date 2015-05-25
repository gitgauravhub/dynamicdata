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

namespace SimpleForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full Name: ");
            sb.Append(txtFullName.Text);
            sb.Append(" Sex: ");
            sb.Append((bool)rdoMale.IsChecked ? "Male" : "Female");
            sb.Append(" Computer: ");
            sb.Append((bool)Desktop.IsChecked ? "Desktop" : "");
            sb.Append((bool)Laptop.IsChecked ? "Desktop" : "");
            sb.Append((bool)Tablet.IsChecked ? "Desktop" : "");
            sb.Append(" Your Job: ");
            sb.Append(cmbJob.SelectionBoxItem.ToString());
            sb.Append(" Delivery Date: ");
            sb.Append(calDeliveryDate.SelectedDate.ToString());
            MessageBox.Show(sb.ToString());
        }

        private void cmbJob_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newSelectedItem = e.AddedItems[0];
            MessageBox.Show(newSelectedItem.ToString());
        }
    }
}
