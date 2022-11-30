namespace Ovning5
{
    internal class Bus : Vehicle
    {
        public int NumberOfPassengers { get; }
        public Bus(string color, string make, string model, string registrationNumber, int numberOfPassengers) : base(color, make, model, registrationNumber)
        {
            NumberOfPassengers = numberOfPassengers;
        }
        public override string ToString()
        {
            return $"{base.ToString()} holding {NumberOfPassengers} passengers";
        }

        //protected override string generateRegistrationNumber()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
