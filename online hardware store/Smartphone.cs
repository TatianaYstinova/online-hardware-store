using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace online_hardware_store
{
    public class Smartphone : AbstractGoods
    {
        public Smartphone( string name, string manufacturer, double memory, double screenSize, double price, int cameraResolution) : base( 
            name,
            manufacturer, 
            memory, 
            screenSize,
            price,
            0.07)
        {
            CameraResolution = cameraResolution;
        }
        public double CameraResolution { get; set; }
        public override bool Equals(object? obj)
        {
            return obj is Smartphone smartphone &&
                   base.Equals(obj) &&
                   Name == smartphone.Name &&
                   Manufacturer == smartphone.Manufacturer &&
                   Memory == smartphone.Memory &&
                   ScreenSize == smartphone.ScreenSize &&
                   Price == smartphone.Price &&
                   CameraResolution == smartphone.CameraResolution;
        }
    }
}
