using online_hardware_store;

Smartphone SmartphoneOne = new Smartphone()
{
    Name= "Galaxy ",
    Manufacturer= "Samsung",
    Memory = 118,
    ScreenSize = 6.1,
    Price = 100,
    CameraResolution = 12.0
};


Flatbed FlatbedOne = new Flatbed()
{
    Name = "Galaxy Tab",
    Manufacturer = "Samsung",
    Memory = 223,
    ScreenSize = 10,
    Price = 60,
    StylusSupport = true
};
Laptop LaptopOne = new Laptop()
{
    Name = "Galaxy Book",
    Manufacturer = "Samsung",
    Memory = 431,
    ScreenSize = 18,
    Price = 1100,
    BatteryLife = 15
};
Console.WriteLine(SmartphoneOne.DoInformation());
Console.WriteLine(LaptopOne.DoInformation());
Console.WriteLine(FlatbedOne.DoInformation());

Console.WriteLine(SmartphoneOne.GetPrice(4));
Console.WriteLine(FlatbedOne.GetPrice(1));
Console.WriteLine(LaptopOne.GetPrice(2));

Console.WriteLine(LaptopOne.Equals(FlatbedOne));
