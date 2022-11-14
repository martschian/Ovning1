using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(int weight, string name, string description, int age, bool howlsAtTheMoon = false) : base(weight, name, description, age, howlsAtTheMoon)
        {
        }

        public string Talk()
        {
            return "I don't howl at the moon like some animal!";
        }
    }
}
