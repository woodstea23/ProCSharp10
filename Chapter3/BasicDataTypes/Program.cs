using System.Numerics;

Console.WriteLine("Hello, Basic Data Types!");
LocalVarDeclarations();

static void LocalVarDeclarations()
{
    Console.WriteLine("Local Variable Declarations:");
    int myInt = 0;
    string myString = "This is my character data";

    bool b1 = true, b2 = false, b3 = b1;

    System.Boolean b4 = false;

    Console.WriteLine($"Integer: {myInt}, String: {myString}, Boolean b1: {b1}, Boolean b2: {b2}, Boolean b3: {b3}, Boolean b4: {b4}");

    Console.WriteLine();
    Console.ReadKey();
}

static void DefaultDeclarations()
{
    Console.WriteLine("Default Declarations:");
    int myInt = default;
    Console.WriteLine($"Default integer: {myInt}");
}
