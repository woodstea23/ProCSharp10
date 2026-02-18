namespace Employees;

//Managers need to know their number of stock options
class Manager : Employee
{
    public int StockOptions { get; set; }

    // Default constructor - needed for object initialization with property setters
    public Manager() { }

    // Custom constructor - allows setting all properties at once
    // Note: The base constructor is called to initialize the inherited properties
    public Manager(string fullName, int age, int empId, float currPay, string ssn, int numberOfOpts) 
        : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried)
    {
        // Initialize the StockOptions property specific to Manager
        StockOptions = numberOfOpts;
    }

    // Override the GiveBonus method to include stock options in the bonus calculation
    public override void GiveBonus(float amount)
    {
        base.GiveBonus(amount);  // Call the base class method to apply the standard bonus logic
        Random r = new Random();
        StockOptions += r.Next(500);  // Add a random number of stock options as part of the bonus
    }

    // Override the DisplayStats method to include stock options information
    public override void DisplayStats()
    {
        base.DisplayStats();  // Call Employee's version first
        Console.WriteLine("Stock Options: {0}", StockOptions);
    }

}