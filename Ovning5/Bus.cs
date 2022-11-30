namespace Ovning5
{
    internal class Bus : Vehicle
    {
        public int NumberOfPassengers { get; }
        public Bus(string color, string make, string model, string registrationNumber, int numberOfPassengers) : base(color, make, model, registrationNumber)
        {
            NumberOfPassengers = numberOfPassengers;
        }


        //protected override string generateRegistrationNumber()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
