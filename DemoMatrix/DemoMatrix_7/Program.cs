using System;
using System.Linq;

namespace DemoMatrix_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                int remainder = number % 3;
                
                    sizes[remainder]++;
                
            }

            int[][] jagged =
            {
                new int [sizes[0]],
                new int [sizes[1]],
                new int [sizes[2]]
            };

            int[] offsets = new int[3];

            foreach (var number in numbers)
            {
                int remainder = number % 3;

                int index = offsets[remainder];

                jagged[remainder][index] = number;

                offsets[remainder]++;
            }
            foreach (var array in jagged)
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
