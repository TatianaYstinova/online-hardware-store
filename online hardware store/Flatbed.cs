﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_hardware_store
{
    public class Flatbed: AbstractGoods
    {

        public Flatbed(string name, string manufacturer, double memory, double screenSize, double price, double discountPercentage, bool stylusSupport) : base(
            name,
            manufacturer,
            memory,
            screenSize,
            price,
            discountPercentage)
        {
            StylusSupport = stylusSupport;
        }
        public bool StylusSupport { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Flatbed flatbed &&
                   StylusSupport == flatbed.StylusSupport;
        }
    }
}
