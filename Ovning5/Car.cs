using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning5
{
    internal class Car : Vehicle
    {
        public int NumberOfSeats { get; private set; }
        public Car(string color, string make, string model, string registrationNumber, int numberOfSeats) : base(color, make, model, registrationNumber)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return base.ToString() + $" with {NumberOfSeats} seats";
        }

        //protected override string generateRegistrationNumber()
        //{
        //    return "MAG545";
        //}
    }
}
