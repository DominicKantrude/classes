using System;
using System.Collections.Generic;

namespace classes
{
    class Company
    {

        public DateTime CreatedOn { get; }
        public string Name { get; }


        // Create a public property for holding a list of current employees

        public Company(string name)
        {
            Name = name;
            CreatedOn = DateTime.Now;

        }


        public List<Employee> Employees = new List<Employee>();

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Employee: {employee.Firstname}");
            }
        }

    }

}