using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public class Flatbed: AbstractGoods
    {
        public bool StylusSupport { get; set; }

        public Flatbed(string name, string manufacturer, double memory, double screenSize, double price, double discountPercentage, bool stylusSupport) : base(
            name,
            manufacturer,
            memory,
            screenSize,
            price,
            0.05)
        {
            StylusSupport = stylusSupport;
        }

        public override bool Equals(object? obj)
        {
            return obj is Flatbed flatbed &&
                   StylusSupport == flatbed.StylusSupport;
        }

       
    }
}
