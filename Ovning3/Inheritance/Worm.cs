using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Worm : Animal
    {
        public bool IsVenomous { get; set; }
        public override string DoSound()
        {
            return "ssssslither";
        }
        public override string Stats()
        {
            return $"{base.Stats()} IsVenomous: {IsVenomous}";
        }
    }
}
