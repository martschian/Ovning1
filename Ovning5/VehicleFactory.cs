using Ovning5.Extensions;
using System.Runtime.CompilerServices;

namespace Ovning5
{
    internal class VehicleFactory
    {
        internal static List<IVehicle> GetVehicles(int numberOfVehicles)
        {
            var vehicles = new List<IVehicle>();
            var rnd = new Random();

            for (int i = 0; i < numberOfVehicles; i++)
            {
                switch (rnd.Next(1, 5))
                {
                    case 1:
                        vehicles.Add(new Car("Blue", "Volvo", "740", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 4));
                        break;
                    case 2:
                        vehicles.Add(new Airplane("White", "Airbus", "330", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 20));
                        break;
                    case 3:
                        vehicles.Add(new Motorcycle("Black", "Harley-Davidson", "Softtail", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 2));
                        break;
                    case 4:
                        vehicles.Add(new Bus("Red", "Scania", "Citywide", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 70));
                        break;
                    case 5:
                        vehicles.Add(new Boat("Wood", "Aquafina", "Velvet", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 1));
                        break;
                }
            }
            return vehicles;
        }
    }
}