// Display a simple message to the user.
Console.WriteLine("***** My First C# App *****");
Console.WriteLine("Hello World!");
Console.WriteLine();
// Process command-line arguments.
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine($"args[{i}] = {args[i]}");
}

// Wait for any key to be pressed before closing.
Console.ReadKey();
