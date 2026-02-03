namespace Employees;

abstract partial class Employee
{
    // Constructors.
    public Employee() { }

    public Employee(string name, int id, float pay, string empSsn)
        :this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried) { }

    public Employee(string name, int age, int id, 
        float pay, string empSsn, EmployeePayTypeEnum payType)
    {
        Name = name;
        Id = id;
        Age = age;
        Pay = pay;
        SocialSecurityNumber = empSsn;
        PayType = payType;
    }

    // Methods.
    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            {PayType: EmployeePayTypeEnum.Commission } => Pay += .10F * amount,
            {PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount/2080F,
            {PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
            _ => Pay+=0
        };
    }

    public virtual void DisplayStats()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("ID: {0}", Id);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Pay: {0}", Pay);
    }
}
