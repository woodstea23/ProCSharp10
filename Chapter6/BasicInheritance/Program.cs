using BasicInheritance;

Console.WriteLine("Basic Inheritance Example");
// Make a car object, set max speed and current speed
Car myCar = new(maxSpeed: 80) { Speed = 50 };

// Print current speed
Console.WriteLine($"My car is going {myCar.Speed} MPH");
Console.WriteLine();

// Now make a MiniVan object
MiniVan myVan = new() { Speed = 30 };
Console.WriteLine($"My van is going {myVan.Speed} MPH");
Console.ReadLine();