using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Inheritance
{
    internal class Swan : Bird
    {
        public bool IsUgly { get; set; }
        public override string Stats()
        {
            return $"{base.Stats()} IsUgly: {IsUgly}";
        }
    }
    
}
