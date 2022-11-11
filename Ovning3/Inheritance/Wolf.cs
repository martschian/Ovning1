using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Wolf : Animal
    {
        public bool HowlsAtTheMoon { get; set; } = true;
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
