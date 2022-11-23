namespace Ovning5
{
    internal abstract class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        protected Vehicle(string registrationNumber, string color, string make, string model)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            Make = make;
            Model = model;
        }
    }
}