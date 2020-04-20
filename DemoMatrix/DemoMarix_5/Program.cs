using System;

namespace DemoMarix_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray =
            {
                new int[] { 5,7,2},
                new int[] { 10,20,30,50},
                new int[] { 3, 25}
            };

            foreach (var array in jaggedArray)
            {
                foreach (var element in array)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
        }
    }
}
