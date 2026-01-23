ShowEnvironmentDetails();
Console.ReadLine();

static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine
    // and other interesting details.
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine($"Drive: {drive}");
    }
    Console.WriteLine($"OS Version: {Environment.OSVersion}");
    Console.WriteLine($"Machine Name: {Environment.MachineName}");
    Console.WriteLine($"Number of processors: {Environment.ProcessorCount}");
    Console.WriteLine($".NET Core Version: {Environment.Version}");
}

