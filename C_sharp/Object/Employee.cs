using System;
using System.Text;
using System.Collections.Generic;

namespace C_sharp.Object
{
    public class Employee : IEmployeeAction
    {
        #region Properties
        public string Name { get; set; }
        public string Age { get; set; }
        #endregion

        #region varructor

        public Employee(string name, string age)
        {
            Name = name;
            Age = age;
        }
        #endregion

        #region Methods

        public List<Employee> AddEmployee(string name, string age)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(name, age));
            return employees;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"My name is: {Name}, and I am {Age} years old");
        }

        public void ExtInfo()
        {
            var currentStartTime = DateTime.Now;
            var currentStartSecond = currentStartTime.Second;
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("John", "25"));
            var currentEndTime = DateTime.Now;
            var currentEndSecond = currentEndTime.Second;
            var timeDifference = currentEndSecond - currentStartSecond;
            var employeeIndex = employees.Count;
            Console.WriteLine($"This is {employeeIndex} employee Who is {Name} and {Age} years old after {timeDifference} seconds");
        }
        #endregion

    }
}