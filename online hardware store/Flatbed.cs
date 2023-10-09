using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public class Flatbed : Goods
    {
        public bool StylusSupport { get; set; }

        public override double GetPrice(int number)
        {
            const double DiscountPercentage = 0.09;
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
