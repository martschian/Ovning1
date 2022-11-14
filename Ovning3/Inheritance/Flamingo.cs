using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Flamingo : Bird
    {
        public Flamingo(int weight, string name, string description, int age, double wingSpan, string color) : base(weight, name, description, age, wingSpan)
        {
            Color = color;
        }

        public string Color { get; set; } = "Pink";
        public override string Stats()
        {
            return $"{base.Stats()} Color: {Color}";
        }
    }
}
