using SimpleClassExample;

Console.WriteLine("***** Fun with Class Types *****\n");

Motorcycle mc = new();
mc.PopAWheely();

// Allocate and configure a Car object.
Car myCar = new("Zippy");

// Speed up the car a few times and print out the new state.
for (int i = 0; i < 5; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}
Console.ReadLine();
