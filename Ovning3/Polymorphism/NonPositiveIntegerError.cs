using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Polymorphism
{
    internal class NonPositiveIntegerError : UserError
    {
        public override string UEMessage()
        {
            return "This value has to be a postive integer.";
        }
    }
}
