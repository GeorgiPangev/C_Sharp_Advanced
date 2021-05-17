using System;
using System.Linq;

namespace SumMatrixColums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimantions = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dimantions[0], dimantions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

          

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    sum += matrix[r,col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
