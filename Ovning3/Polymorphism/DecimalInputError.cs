using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Polymorphism
{
    internal class DecimalInputError : UserError
    {
        public override string UEMessage()
        {
            return "This field has to be a decimal value";
        }
    }
}
