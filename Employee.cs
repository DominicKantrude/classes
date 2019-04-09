using System;

namespace classes
{
    class Employee
    {
        public Employee(string name)
        {
            Firstname = name;
        }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public string title { set; get; }
        public DateTime startDate { set; get; }




    }

}