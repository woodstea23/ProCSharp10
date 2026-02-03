namespace Employees;

//SalesPeople need to know their number of sales
class SalesPerson : Employee
{
    public int SalesNumber { get; set; }

    public SalesPerson() { }
    
    public SalesPerson(string fullName, int age, int empId, float currPay, string ssn, int salesNum) 
        : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Commission)
    {
        SalesNumber = salesNum;
    }

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine("Sales Number: {0}", SalesNumber);
    }

}