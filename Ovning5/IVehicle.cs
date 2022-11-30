namespace Ovning5
{
    internal interface IVehicle
    {
        string Color { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        string RegistrationNumber { get; }

        string ToString();
    }
}