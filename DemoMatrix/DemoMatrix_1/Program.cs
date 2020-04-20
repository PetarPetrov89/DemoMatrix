﻿using System;

namespace DemoMatrix_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
             {
                { 1,2,3,4,},
                { 2,3,4,5}
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($" {matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
