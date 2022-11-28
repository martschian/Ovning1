namespace Ovning5
{
    internal abstract class Vehicle
    {
        protected static HashSet<string> _registrationNumbers = new ();
        public string RegistrationNumber { get; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        /// <summary>
        /// Vehicle constructor
        /// </summary>
        /// <param name="color"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="registrationNumber"></param>
        /// <exception cref="ArgumentException"></exception>
        protected Vehicle(string color, string make, string model, string registrationNumber)
        {
            RegistrationNumber = registrationNumber.ToUpper();
            if (!_registrationNumbers.Add(registrationNumber))
                throw new ArgumentException("The registration number already exists");
            Color = color;
            Make = make;
            Model = model;
            
        }

        // protected abstract string generateRegistrationNumber();

        public override string ToString()
        {
            return $"{RegistrationNumber}: A {Color} {Make} {Model}";
        }
    }
}