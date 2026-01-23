Console.WriteLine("***** Basic Console I/O *****");
GetUserData();
Console.ReadLine();

static void GetUserData()
{
    // Get name.
    Console.Write("Enter your name: ");
    string userName = Console.ReadLine();

    // Get age.
    Console.Write("Enter your age: ");
    string ageAsString = Console.ReadLine();
    int userAge = int.Parse(ageAsString);

    // Change echo color, just for fun.
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    // Output the data.
    Console.WriteLine($"Hello {userName}, you are {userAge} years old.");

    // Restore previous color.
    Console.ForegroundColor = prevColor;
}
