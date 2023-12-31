﻿using online_hardware_store;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace online_hardware_store
{
    public class Laptop : AbstractGoods
    {
        public double BatteryLife { get; set; }
        public Laptop(string name, string manufacturer, double memory, double screenSize, double price, double discountPercentage, double batteryLife) : base(
            
            name,
            manufacturer,
            memory,
            screenSize,
            price,
            0.09)
        {
            BatteryLife=batteryLife;
        }

        public override bool Equals(object? obj)
        {
            return obj is Laptop laptop &&
                   BatteryLife == laptop.BatteryLife;
        }
    }
}
