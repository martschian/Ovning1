namespace Ovning5
{
    internal class Boat : Vehicle
    {
        public Boat(string color, string make, string model, string registrationNumber, int numberOfEngines) : base(color, make, model, registrationNumber)
        {
            NumberOfEngines = numberOfEngines;
        }

        public int NumberOfEngines { get; }

        public override string ToString()
        {
            return $"{base.ToString()} with {NumberOfEngines} engines.";
        }

        //protected override string generateRegistrationNumber()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
