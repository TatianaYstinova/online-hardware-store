using online_hardware_store;

Smartphone SmartphoneOne = new Smartphone("Galaxy", "Samsung", 118, 6.1, 100, 12);
Flatbed FlatbedOne = new Flatbed("Galaxy Tab", "Samsung", 223, 10, 60, 0.09, true);
Laptop LaptopOne = new Laptop("Galaxy Book", "Samsung", 431, 18, 1100, 0.05, 15);

Console.WriteLine(SmartphoneOne.DoInformation());
Console.WriteLine(LaptopOne.DoInformation());
Console.WriteLine(FlatbedOne.DoInformation());

Console.WriteLine(SmartphoneOne.GetPrice(10));
Console.WriteLine(FlatbedOne.GetPrice(1));
Console.WriteLine(LaptopOne.GetPrice(2));


Smartphone SmartphoneTwo = new Smartphone("Galaxy", "Samsung", 118, 6.1, 100, 12);
if (SmartphoneOne.Equals(SmartphoneTwo))
{
    Console.WriteLine(" Равны");
}
else
{
    Console.WriteLine("Не равны");
}