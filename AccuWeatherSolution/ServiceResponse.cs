using System;
using System.Collections;
using System.Collections.Generic;

namespace AccuWeatherSolution
{
    public class ServiceResponse<T> : IEnumerable<T>
    {
        public T? Data { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            if (Data is IEnumerable<T> enumerableData)
            {
                return enumerableData.GetEnumerator();
            }
            else
            {
                throw new InvalidOperationException("Data is not enumerable.");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
