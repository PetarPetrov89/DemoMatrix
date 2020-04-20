using System;

namespace DemoMatrix_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[5][];

            for (int i = 0; i < jagged.Length; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersArray = numbers.Split(' ');

                jagged[i] = new int[numbersArray.Length];

                for (int y = 0; y < jagged[i].Length; y++)
                {
                    jagged[i][y] = int.Parse(numbersArray[y]);
                }
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
