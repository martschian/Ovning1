using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Pelican : Bird
    {
        public Pelican(int weight, string name, string description, int age, double wingSpan, bool beakIsFullOfFish) : base(weight, name, description, age, wingSpan)
        {
            BeakIsFullOFish = beakIsFullOfFish;
        }

        public bool BeakIsFullOFish { get; set; }
        public override string Stats()
        {
            return $"{base.Stats()} BeakIsFullOFish: {BeakIsFullOFish}";
        }
    }
}
