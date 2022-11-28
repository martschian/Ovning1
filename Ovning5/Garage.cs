using System.Collections;

namespace Ovning5
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private readonly T[] vehicles;
        private readonly Stack<int> freeSpaces = new();
        public int Count => Capacity - freeSpaces.Count;
        public int Capacity { get; }
        public bool HasFreeSpace => freeSpaces.Count > 0;

        public Garage(int capacity)
        {
            Capacity = capacity;
            // this.Count = 0;
            IEnumerable<int> range = Enumerable.Range(0, capacity).Reverse();
            foreach (var number in range)
            {
                freeSpaces.Push(number);
            }
            vehicles = new T[capacity];
        }

        /// <summary>
        /// Parks the provided vehicle in the garage
        /// </summary>
        /// <param name="vehicle">The vehicle to be parked</param>
        /// <returns>True if there a parking spot was available, otherwise false</returns>
        public (bool, string) ParkVehicle(T vehicle)
        {
            ArgumentNullException.ThrowIfNull(vehicle, nameof(vehicle));
            if (!HasFreeSpace) return (false, "There are no free parking spaces!");

            vehicles[FindFreeParkingSpace()] = vehicle;
            return (true, $"{vehicle} has been parked");
        }

        /// <summary>
        /// Searches the garage for a matching vehicle
        /// </summary>
        /// <param name="registrationNumber">The registration number of the requested vehicle</param>
        /// <returns>The index of the vehicle or -1</returns>
        public int FindVehicle(string registrationNumber)
        {
            // var result = vehicles.FirstOrDefault(vehicle => vehicle.RegistrationNumber == registrationNumber);
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle?.RegistrationNumber == registrationNumber)
                    return Array.IndexOf<Vehicle>(vehicles, vehicle);
            }
            return -1;
        }

        /// <summary>
        /// Finds the first free parking space in the garage
        /// </summary>
        /// <returns>The index of the first free space or -1</returns>
        public int FindFreeParkingSpace()
        {
            if (!HasFreeSpace) return -1;
            return freeSpaces.Pop();
        }

        public Vehicle? RetrieveVehicle(string registrationNumber)
        {
            if (Count == 0) return null;

            var parkingSpace = FindVehicle(registrationNumber);
            if (parkingSpace != -1)
            {
                var vehicle = vehicles[parkingSpace];
                vehicles[parkingSpace] = null;
                freeSpaces.Push(parkingSpace);
                return vehicle;
            }
            return null;
        }

        /// <summary>
        /// Get all vehickles
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAllVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                    yield return vehicle;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle != null)
                    yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}