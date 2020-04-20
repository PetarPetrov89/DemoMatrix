using System;

namespace DemoMatrix_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1,2,3,4},
                { 2,3,4,5},
                { 4,56,5,2}
            };

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
