using Ovning5.Extensions;
using System.Runtime.CompilerServices;

namespace Ovning5
{
    internal class VehicleFactory
    {
        /// <summary>
        /// Generate random type of vehicle(s)
        /// </summary>
        /// <param name="numberOfVehicles"></param>
        /// <returns></returns>
        internal static List<IVehicle> GetVehicles(int numberOfVehicles = 1)
        {
            var vehicles = new List<IVehicle>();
            var colors = new string[] { "black", "white", "silver", "red", "blue", "green", "yellow" };
            var rnd = new Random();

            for (int i = 0; i < numberOfVehicles; i++)
            {
                switch (rnd.Next(1, 6))
                {
                    case 1:
                        vehicles.Add(new Car(colors[rnd.Next(colors.Length)], "Volvo", "740", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 4));
                        break;
                    case 2:
                        vehicles.Add(new Airplane(colors[rnd.Next(colors.Length)], "Airbus", "330", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 20));
                        break;
                    case 3:
                        vehicles.Add(new Motorcycle(colors[rnd.Next(colors.Length)], "Harley-Davidson", "Softtail", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 2));
                        break;
                    case 4:
                        vehicles.Add(new Bus(colors[rnd.Next(colors.Length)], "Scania", "Citywide", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 70));
                        break;
                    case 5:
                        vehicles.Add(new Boat(colors[rnd.Next(colors.Length)], "Aquafina", "Velvet", rnd.RandomRegistrationNumber(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"), 1));
                        break;
                }
            }
            return vehicles;
        }
    }
}