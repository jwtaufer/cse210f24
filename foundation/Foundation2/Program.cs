using System;

class Program
{
    static void Main(string[] args)
    {
        Order jake = new Order(
            "Jake Taufer",
            "1095 Nalder St",
            "Layton",
            "UT",
            "United States"
        );

        jake.AddProduct(
            "8Bitdo Lite 2 Bluetooth Gamepad for Switch, Switch Lite, Android and Raspberry Pi",
            "8BIT2",
            34.99,
            2
        );

        jake.AddProduct(
            "Star Wars Rebels: Complete Series Seasons 1-4 DVD",
            "DVD94",
            69.98,
            1
        );
        

        Console.WriteLine($"Total Cost: ${jake.CalculateCost()}");

        Console.WriteLine();

        Console.WriteLine("Packing Label: ");
        jake.DisplayPackingLabel();

        Console.WriteLine();

        Console.WriteLine("Shipping Label: ");
        jake.DisplayShippingLabel();
    }
}