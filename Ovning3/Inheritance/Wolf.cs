using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Wolf : Animal
    {
        public Wolf(int weight, string name, string description, int age, bool howlsAtTheMoon) : base(weight, name, description, age)
        {
            HowlsAtTheMoon = howlsAtTheMoon;
        }

        public bool HowlsAtTheMoon { get; set; }
        public override string DoSound()
        {
            return "Awwwoooo";
        }
        public override string Stats()
        {
            return $"{base.Stats()} HowlsAtTheMoon: {HowlsAtTheMoon}";
        }
    }
}
