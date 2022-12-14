using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(int weight, string name, string description, int age, int numberOfSpikes) : base(weight, name, description, age)
        {
            NumberOfSpikes= numberOfSpikes;
        }

        public int NumberOfSpikes { get; set; }
        public override string DoSound()
        {
            return "Hedgehog noises";
        }
        public override string Stats()
        {
            return $"{base.Stats()} NumberOfSpikes: {NumberOfSpikes}";
        }
    }
}
