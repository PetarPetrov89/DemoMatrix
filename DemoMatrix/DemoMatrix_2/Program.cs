using System;

namespace DemoMatrix_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo Matrix from console

            Console.WriteLine("Моля въведете броя редове!");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Моля въведете броя колони!");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Моля въведете елементите на матрицата");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine($"Моля въведете стойност за елемента [{row},{col}]");
                    matrix[row, col] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("Готово");

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($" {matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}