using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public class Goods
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Memory { get; set; }
        public double ScreenSize { get; set; }
        public double Price { get; set; }

        public string  DoInformation()
        {
            return $"Manufacturer:{Manufacturer} ,Name:{Name} ,Price:{Price}";
        }
        public virtual double GetPrice(int number)
        {
            return Price * number;
        }
    }

}
