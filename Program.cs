using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("jimmyJohn");
            Employee employee2 = new Employee("BillyBob");
            Employee employee3 = new Employee("PinheadLArry");

            Company datCompany = new Company("amazon");

            datCompany.Employees.Add(employee1);
            datCompany.Employees.Add(employee2);
            datCompany.Employees.Add(employee3);

            datCompany.ListEmployees();
        }
    }
}
