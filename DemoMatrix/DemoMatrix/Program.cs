using System;

namespace DemoMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int[,] twoDimArray = new int[3, 4];

            int[,] matrix =
            {
                { 1,2,3,4,},
                { 2,3,4,5}
            };
            int element = matrix[0, 2];
            Console.WriteLine(element);
        }
    }
}
