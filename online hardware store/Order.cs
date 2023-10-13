using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    internal class Order
    {
        public string NameCustomers { get; set; }
        public double DateOfCreation { get; set; }
        public double OrderPosition{ get;set; }
        public double NumberOfOrders { get; set; }

        public double GetPrice(int number,int price , int _discountPercentage)
        {
            double sum = price * number;

            if (number >= 5)
            {
                double discount = _discountPercentage * sum;

                return sum - discount;
            }

            return sum;
        }


    }
}
