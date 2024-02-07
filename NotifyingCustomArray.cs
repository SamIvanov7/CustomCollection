using System.Collections;

namespace SolarPowerEngineering
{
    public class NotifyingCustomArray<T> : IArrayManagement<T>, IEnumerable<T>
    {
        private CustomArray<T> _innerArray;
        public event EventHandler ArrayExpanded;

        public NotifyingCustomArray()
        {
            _innerArray = new CustomArray<T>();
        }

        public void Add(T element)
        {
            int originalCount = _innerArray.Count;
            _innerArray.Add(element);
            if (_innerArray.Count > originalCount)
            {
                ArrayExpanded?.Invoke(this, EventArgs.Empty);
            }
        }

        public T this[int index]
        {
            get => _innerArray[index];
            set => _innerArray[index] = value;
        }

        public int Count => _innerArray.Count;

        public IEnumerator<T> GetEnumerator()
        {
            return _innerArray.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
