using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string department = input[2];

                Employee employee = new Employee(name, salary, department);

                employees.Add(employee);
            }

            Console.WriteLine();
        }
    }

    class Employee
    {
        public Employee()
        {

        }

        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
