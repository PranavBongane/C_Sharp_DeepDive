using _04_Inheritance;

Console.WriteLine("=== Inheritance Demo ===\n");

// Create a Car
Car myCar = new Car("Tesla", 120, 4);
myCar.Start();         // Inherited from Vehicle
myCar.OpenTrunk();     // Car-specific
myCar.Stop();

// Create a Bike
Bike myBike = new Bike("Yamaha", 80, true);
myBike.Start();        // Inherited from Vehicle
myBike.DoWheelie();    // Bike-specific
myBike.Stop();

// Show unique properties
Console.WriteLine($"\nCar has {myCar.NumberOfDoors} doors.");
Console.WriteLine($"Bike has carrier: {myBike.HasCarrier}");
