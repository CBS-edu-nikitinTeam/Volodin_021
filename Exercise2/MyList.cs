using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class MyList<T>
    {
        private const int DefaultSize = 10;
        private T[] _array;
        public int Length { get; private set; } = 0;

        public MyList()
        {
            _array = new T[DefaultSize];
        }

        public void Push(T value)
        {
            if (Length == _array.Length)
            {
                T[] temp = new T[_array.Length * 2];
                Array.Copy(_array, temp, _array.Length);
                _array = temp;
            }

            _array[Length++] = value;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 && index + 1 > _array.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return _array[index];
            }
        }
    }
}
