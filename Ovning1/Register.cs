using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    internal class Register
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee()
        {
            
            Console.Write("Namn: ");
            string name = Console.ReadLine();

            Console.Write("Lön: ");
            double wage = double.Parse(Console.ReadLine());

            employees.Add(new Employee(name, wage));
        }
        public void DisplayEmployees()

        {
            if (employees.Count > 0)
            {
                foreach (Employee employee in employees)
                {
                    employee.displayDetails();
                }
            } 
            else
            {
                Console.WriteLine("Det finns inga anställda förnärvarande.");
            }
            
        }
    }
    
}
