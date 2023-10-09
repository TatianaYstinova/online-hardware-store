using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public class Laptop : Goods
    {
        public double BatteryLife { get; set; }

        public override double GetPrice(int number)
        {
            const double DiscountPercentage = 0.05;
            double discount = DiscountPercentage * (Price * number);
            if (number >= 5)
            {
                double WholesalePrice = Price - discount;
            }
            else
            {
                discount = 0;
            }
            return Price * number - discount;
        }
    }
}
