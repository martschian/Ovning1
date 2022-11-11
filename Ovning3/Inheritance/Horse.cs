using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Horse : Animal
    {
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
