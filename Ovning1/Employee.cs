using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    internal class Employee

    {
        private string name;
        private double wage;

        public Employee(string fullName, double monthlyWage)
        {
            name = fullName;
            wage = monthlyWage;
        }

        internal void displayDetails()
        {
            Console.WriteLine($"{name} tjänar {wage} per månad");
        }
        public override string ToString()
        {
            return $"{name} tjänar {wage} per månad";
        }
    }
}
