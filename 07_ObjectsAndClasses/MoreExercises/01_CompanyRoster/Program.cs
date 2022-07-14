using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CompanyRoster
{  
    public class Department
    {
        public Department(string name)
        {
            this.Name = name;

            this.Employees = new List<Employee>();
        }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
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

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            List<Department> departments = new List<Department>();

            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = employeeInfo[0];
                decimal salary = decimal.Parse(employeeInfo[1]);
                string departmentName = employeeInfo[2];

                Department department = departments.FirstOrDefault(d => d.Name == departmentName);

                if (department == null)
                {
                    department = new Department(departmentName);
                    departments.Add(department);
                }

                Employee employee = new Employee(name, salary, departmentName);
                department.Employees.Add(employee);
            }

            Department bestDepartment = departments
                .OrderByDescending(d => d.Employees.Average(e => e.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.Name}");

            foreach (var employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}