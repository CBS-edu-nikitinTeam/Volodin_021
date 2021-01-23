using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>();

            for (int i = 0; i < 11; i++)
            {
                intList.Push(i + 1);
            }

            MyList<string> stringList= new MyList<string>();

            for (int i = 0; i < 11; i++)
            {
                stringList.Push(i.ToString() + "A");
            }
        }
    }
}
