using System;

namespace DemoMatrix_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
           {
                { 1,2,3,4,7,2},
                { 2,3,4,5,9,3},
                { 4,6,5,2,1,5},
                { 4,6,5,2,6,8}
            };

            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            for (int x = 0; x < matrix.GetLength(0) - 1; x++)
            {
                for (int y = 0; y < matrix.GetLength(1) - 1; y++)
                {
                    int sum = matrix[x, y] + matrix[x, y + 1] + matrix[x + 1, y] + matrix[x + 1, y + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = x;
                        bestCol = y;
                    }
                
                }
            }
            Console.WriteLine($"{matrix[bestRow,bestCol]} {matrix[bestRow,bestCol + 1]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]}");

            Console.WriteLine(bestSum);
        }
    }
}
