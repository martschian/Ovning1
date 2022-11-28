namespace Ovning5
{
    internal class Motorcycle : Vehicle
    {
        private readonly int numberOfWheels;

        public Motorcycle(string color, string make, string model, string registrationNumber, int numberOfWheels) : base(color, make, model, registrationNumber)
        {
            this.numberOfWheels = numberOfWheels;
        }

        //protected override string generateRegistrationNumber()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
