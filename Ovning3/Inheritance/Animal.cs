using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal abstract class Animal
    {
        // 3.3.14
        // Om samtliga djur behöver ett nytt attribut skulle vi lägga det här

        public int Weight { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public abstract string DoSound();
        public Animal(int weight, string name, string description, int age)
        {
            Weight = weight;
            Name = name;
            Description = description;
            Age = age;

        }
        public virtual string Stats()
        {
            return $"Weight: {Weight}, Name: {Name}, Description: {Description}, Age: {Age}";
        }
    }
}
