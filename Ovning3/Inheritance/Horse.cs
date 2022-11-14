using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Horse : Animal
    {
        public Horse(int weight, string name, string description, int age, bool isPony) : base(weight, name, description, age)
        {
            IsPony= isPony;
        }

        public bool IsPony { get; set; }
        public override string DoSound()
        {
            return "Neeeeigh";
        }
        public override string Stats()
        {
            return $"{base.Stats()} IsPony: {IsPony}";
        }
    }
}
