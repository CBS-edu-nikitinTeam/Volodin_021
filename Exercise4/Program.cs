using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Push(1);
            list.Push(2);
            list.Push(3);

            int[] array = list.GetArray<int>();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
