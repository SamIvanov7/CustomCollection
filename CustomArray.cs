using System;
using System.Collections;
using System.Collections.Generic;

namespace SolarPowerEngineering
{
    public class CustomArray<T> : IArrayManagement<T>, IEnumerable<T>
    {
        private T[]_data = new T[0];

        public T this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        public void Add(T element)
        {
            T[] newData = new T[_data.Length + 1];
            _data.CopyTo(newData, 0);
            newData[_data.Length] = element;
            _data = newData;
        }

        public int Count => _data.Length;

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _data)
            {
                yield return item;
            }
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
