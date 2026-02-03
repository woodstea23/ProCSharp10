namespace Employees;

//Managers need to know their number of stock options
class Manager : Employee
{
    public int StockOptions { get; set; }

    public Manager() { }

    public Manager(string fullName, int age, int empId, float currPay, string ssn, int numberOfOpts) 
        : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried)
    {
        StockOptions = numberOfOpts;
    }

    public override void DisplayStats()
    {
        base.DisplayStats();  // Call Employee's version first
        Console.WriteLine("Stock Options: {0}", StockOptions);
    }
}