namespace Ovning5
{
    internal class Motorcycle : Vehicle
    {
        public int NumberOfWheels { get; }

        public Motorcycle(string color, string make, string model, string registrationNumber, int numberOfWheels) : base(color, make, model, registrationNumber)
        {
            NumberOfWheels = numberOfWheels;
        }

        public override string ToString()
        {
            return $"{base.ToString()} with {NumberOfWheels} wheels.";
        }
        //protected override string generateRegistrationNumber()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
