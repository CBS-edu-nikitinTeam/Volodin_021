using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    static class MyListExt
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                result[i] = list[i];
            }

            return result;
        }
    }
}
