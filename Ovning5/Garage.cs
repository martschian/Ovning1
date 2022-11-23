using System.Collections;

namespace Ovning5
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private readonly Vehicle[] vehicles;
        public int Capacity { get; }

        public Garage(int capacity)
        {
            this.Capacity = capacity;
            vehicles = new Vehicle[capacity];

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}