using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02List
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary;

        public Employee(int id, string name, double salary) 
        { 
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Salary { get { return salary; } set { salary = value; } }

        public void increaseSalary(double Percentage)
        {
            this.salary = this.salary * (1 + (Percentage / 100));
        }


    }
}
