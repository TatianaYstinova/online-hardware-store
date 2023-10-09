using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace online_hardware_store
{
    public class Smartphone : Goods
    {
        public double CameraResolution { get; set; }

        public override double GetPrice(int number)
        {
            const double DiscountPercentage =0.07;
            double discount = DiscountPercentage * (Price* number);
            if( number >= 5)
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
