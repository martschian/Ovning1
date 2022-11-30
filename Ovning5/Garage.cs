using System.Collections;

namespace Ovning5
{
    internal class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private readonly T[] _vehicles;
        private readonly Stack<int> _freeParkingSpaces = new();
        public int Count => Capacity - _freeParkingSpaces.Count;
        public int Capacity { get; }
        public bool HasFreeSpace => _freeParkingSpaces.Count > 0;

        public Garage(int capacity)
        {
            Capacity = capacity;
            InitializeFreeSpaces(capacity);
            _vehicles = new T[capacity];
        }

        /// <summary>
        /// Pushes the index of all free spaces onto the stack
        /// </summary>
        /// <param name="capacity">The number of spaces in the garage</param>
        private void InitializeFreeSpaces(int capacity)
        {
            var range = Enumerable.Range(0, capacity).Reverse();
            foreach (int number in range)
            {
                _freeParkingSpaces.Push(number);
            }
        }

        /// <summary>
        /// Parks the provided vehicle in the garage
        /// </summary>
        /// <param name="vehicle">The vehicle to be parked</param>
        /// <returns>True if there a parking spot was available, otherwise false</returns>
        public (bool, string) AddVehicle(T vehicle)
        {
            ArgumentNullException.ThrowIfNull(vehicle, nameof(vehicle));
            if (!HasFreeSpace) return (false, "There are no free parking spaces!");

            _vehicles[GetFreeParkingSpace()] = vehicle;
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
            foreach (var vehicle in _vehicles)
            {
                if (vehicle?.RegistrationNumber == registrationNumber)
                    return Array.IndexOf<T>(_vehicles, vehicle);
            }
            return -1;
        }

        /// <summary>
        /// Finds the first free parking space in the garage
        /// </summary>
        /// <returns>The index of the first free space or -1</returns>
        private int GetFreeParkingSpace()
        {
            if (!HasFreeSpace) return -1;
            return _freeParkingSpaces.Pop();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationNumber"></param>
        /// <returns>The vehicle or default</returns>
        public T GetVehicle(string registrationNumber)
        {
            if (Count == 0) return default!;

            var parkingSpace = FindVehicle(registrationNumber);
            if (parkingSpace != -1)
            {
                var vehicle = _vehicles[parkingSpace];
                _vehicles[parkingSpace] = default!;
                _freeParkingSpaces.Push(parkingSpace);
                return vehicle;
            }
            return default!;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in _vehicles)
            {
                if (vehicle is not null)
                    yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}