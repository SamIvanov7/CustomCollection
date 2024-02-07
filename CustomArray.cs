using System.Collections;

namespace SolarPowerEngineering
{
    public class CustomArray<T> : IArrayManagement<T>, IEnumerable<T>
    {
        private List<T> _data = new List<T>();

        public T this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        public void Add(T element)
        {
            _data.Add(element);
        }

        public int Count => _data.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public interface IArrayManagement<T>
    {
        void Add(T element);
        T this[int index] { get; set; }
        int Count { get; }
    }
}
