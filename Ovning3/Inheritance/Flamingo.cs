using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Flamingo : Bird
    {
        public string Color { get; set; } = "Pink";
        public override string Stats()
        {
            return $"{base.Stats()} Color: {Color}";
        }
    }
}
