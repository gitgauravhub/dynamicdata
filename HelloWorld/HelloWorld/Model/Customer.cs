using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class Customer
    {
        private string _customerCode = string.Empty;

        public string CustomerName
        {
            get { return _customerCode.ToUpper(); }
            set { _customerCode = value; }
        }
        private string amount;

        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string lblAmountColor;

        public string LblAmoountColor
        {
            get { return lblAmountColor; }
            set { lblAmountColor = value; }
        }
        
    }
}
