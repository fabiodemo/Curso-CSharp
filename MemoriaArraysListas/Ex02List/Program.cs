using System;
using System.Globalization;

namespace Ex02List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees?");
            int quant = int.Parse(Console.ReadLine());
            int id;
            string name;
            double salary;
            
            List<Employee> Employees = new List<Employee>();
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id who will receive a salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());
            if (Employees.Any(e => e.Id == (employeeId)))
            {
                Console.Write("Enter the percentage of increase: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employees.FirstOrDefault(e => e.Id == employeeId).increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Employee not found, salary will remain the same!");
            }

            Console.WriteLine("\nUpdated list of employees: ");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}