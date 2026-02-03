namespace Employees;

sealed class PtSalesPerson : SalesPerson
{
    public int HoursWorked { get; set; }

    public PtSalesPerson() { }

    public PtSalesPerson(string fullName, int age, int empId, float currPay, string ssn, int salesNum, int hoursWorked) 
        : base(fullName, age, empId, currPay, ssn, salesNum)
    {
        HoursWorked = hoursWorked;
    }
}