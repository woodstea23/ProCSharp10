using Employees;

// Can't do this now because we made Employee abstract
// Employee emp = new Employee("Bob", 1, 50000, "111-11-1111");
Manager mgr = new Manager("Sue", 30, 2, 80000, "222-22-2222", 5000);
SalesPerson sales = new SalesPerson("Jim", 25, 3, 60000, "333-33-3333", 100);

// All stored as Employee references
Employee[] staff = { mgr, sales };

foreach (Employee e in staff)
{
    e.DisplayStats();  // Calls the RIGHT version automatically!
}
