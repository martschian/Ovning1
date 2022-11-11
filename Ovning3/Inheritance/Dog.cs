﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }
        public override string DoSound()
        {
            return "Woof!";
        }
        public override string Stats()
        {
            return $"{base.Stats()} Breed: {Breed}";
        }
        public string PlayFetch()
        {
            return "Your puppy fetches the ball you threw. Good boy!";
        }
    }
}
