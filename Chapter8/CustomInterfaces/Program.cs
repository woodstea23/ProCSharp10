using CustomInterfaces;

Console.WriteLine("A first look at Interfaces");
CloneableExample();

static void CloneableExample()
{
    // All of these classes support the ICloneable interface.
    string myStr = "Hello";
    OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
    string[] myStrArray = { "Hello", "World" };
    int[] myIntArray = { 1, 2, 3 };

    // Therefore, they can all be passed into a method taking ICloneable.
    CloneMe(myStr);
    CloneMe(unixOS);
    CloneMe(myStrArray);
    CloneMe(myIntArray);
    static void CloneMe(ICloneable c)
    {
        // Clone the object and print out the type of the clone.
        object clone = c.Clone();
        Console.WriteLine($"Your clone is a: {clone.GetType().Name}");
    
        // Check if they're the same reference
        Console.WriteLine($"Same reference? {object.ReferenceEquals(c, clone)}");
    }

}
