using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Bird : Animal
    {
        public Bird(int weight, string name, string description, int age, double wingSpan) : base(weight, name, description, age)
        {
            WingSpan = wingSpan;
        }

        // 3.3.13
        // Om samtliga fåglar behöver ett nytt attribut skulle vi lägga det här

        public double WingSpan { get; set; }
        public override string DoSound()
        {
            return "Caaaw!";
        }
        public override string Stats()
        {
            return $"{base.Stats()} WingSpan: {WingSpan}";
        }
    }
}
