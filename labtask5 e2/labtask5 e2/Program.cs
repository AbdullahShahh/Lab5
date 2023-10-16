using System;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach (int i in numbers2D)
            {
                System.Console.Write("{0}", i);
            }
        }
    }
}