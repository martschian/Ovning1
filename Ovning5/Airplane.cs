namespace Ovning5
{
    internal class Airplane : Vehicle
    {
        public double WingSpan { get; }
        public Airplane(string color, string make, string model, string registrationNumber, double wingSpan) : base(color, make, model, registrationNumber)
        {
            WingSpan = wingSpan;
        }

        public override string ToString()
        {
            return base.ToString() + $" with a wingspan of {WingSpan} meters";
        }

        //protected override string generateRegistrationNumber()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
