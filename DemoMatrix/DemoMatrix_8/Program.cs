using System;

namespace DemoMatrix_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            int[][] triangle = new int[height][];

            int currWidth = 1;

            for (int row = 0; row < height; row++)
            {
                triangle[row] = new int[currWidth];

                int[] currentRow = triangle[row];

                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;

                currWidth++;

                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                        int[] previousRow = triangle[row - 1];
                        int previousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = previousRowSum;
                    }
                }

            }

            for (int row = 0; row < height; row++)
            {
                Console.Write("".PadLeft((height - row) * 2));

                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
    