using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Polymorphism
{
    internal class ValueTooLargeError : UserError
    {
        public override string UEMessage()
        {
            return "The largest value permitted is 10000";
        }
    }
}
