namespace Employees;

partial class Employee
{
    // Field data.
    private string _empName;

    // Properties!
    public string Name
    {
        get => _empName;
        set
        {
            if (value.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = value;
            }
        }
    }

    // Auto-properties (no backing fields needed)
    public int Id { get; set; }
    public float Pay { get; set; }
    public int Age { get; set; }
    public EmployeePayTypeEnum PayType { get; set; }
    
    // Private setter - can only be set within the class
    public string SocialSecurityNumber { get; private set; } = string.Empty;

}

