namespace Ovning5
{
    internal class Motorcycle : Vehicle
    {
        public int NumberOfWheels { get; }

        public Motorcycle(string color, string make, string model, string registrationNumber, int numberOfWheels) : base(color, make, model, registrationNumber)
        {
            NumberOfWheels = numberOfWheels;
        }

        //protected override string generateRegistrationNumber()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
