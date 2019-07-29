using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayLib
{
    public class CustomArray<T>
    {
        private readonly int _start;
        private int _end;

        private T[] _array;

        public CustomArray(int start, int end)
        {
            this._start = start;
            this._end = end;

            var len = _end - _start;
            _array = new T[len + 1];
        }

        public T this[int index]
        {
            get => _array[index - _start];
            set => _array[index - _start] = value;
        }
    }
}
