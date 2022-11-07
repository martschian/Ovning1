using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    internal class Employee

    {
        //private string _name;
        //private double _wage;

        public string Name { get; set; }
        public double Wage { get; set; }

        public Employee(string name, double wage)
        {
            Name = name;
            Wage = wage;
        }

        internal void DisplayDetails()
        {
            Console.WriteLine($"{Name} tjänar {Wage} per månad");
        }
        public override string ToString() => $"{Name} tjänar {Wage} per månad";
        //{
        //    return $"{Name} tjänar {Wage} per månad";
        //}
    }
}
