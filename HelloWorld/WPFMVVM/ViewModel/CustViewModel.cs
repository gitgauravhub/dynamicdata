using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMVVM.Model;

namespace WPFMVVM.ViewModel
{
    public class CustViewModel : INotifyPropertyChanged
    {
        private Customer obj = new Customer();

        public string txtCustomerName
        {
            get { return obj.CustomerName; }
            set { obj.CustomerName = value; }
        }

        public string txtAmount
        {
            get 
            { 
                return obj.Amount.ToString(); 
            }
            set 
            {
                if (value != string.Empty)
                {
                    obj.Amount = Convert.ToInt32(value);
                }

                else
                {
                    obj.Amount = Convert.ToInt32(1);
                }

                UpdateProperty("lblAmountColor"); 
            }
        }

        public string lblAmountColor
        {
            get
            {
                if (obj.Amount > 2000)
                {
                    return "Green";
                }
                else if (obj.Amount > 1500)
                {
                    return "Yellow";
                }
                else
                {
                    return "Brown";
                }
            }
        }

        public bool IsMarried
        {
            get
            {
                if (obj.Married == "Married")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    obj.Married = "Married";
                }
                else
                {
                    obj.Married = "Unmarried";
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void UpdateProperty(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
