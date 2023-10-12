using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public abstract class AbstractGoods
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Memory { get; set; }
        public double ScreenSize { get; set; }
        public double Price { get; set; }
        protected double _discountPercentage { get; private set; }

        public AbstractGoods(string name, string manufacturer, double memory, double screenSize, double price, double discountPercentage)
        {
            Name =  name;
            Manufacturer = manufacturer;
            Memory = memory;
            ScreenSize = screenSize;
            Price = price;
            _discountPercentage = discountPercentage;
        }

        public string  DoInformation()
        {
            return $"Manufacturer:{Manufacturer} ,Name:{Name} ,Price:{Price}";
        }

        public double GetPrice(int number)
        {
            double sum = Price * number;

            if (number >= 5)
            {
                double discount = _discountPercentage * sum;

                return sum - discount;
            }

            return sum;
        }

    } 
}
