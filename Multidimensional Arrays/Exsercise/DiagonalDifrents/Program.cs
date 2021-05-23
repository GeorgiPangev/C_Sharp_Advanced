using System;
using System.Linq;

namespace DiagonalDifrents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] square = new int[n,n];

            for (int row = 0; row < square.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < square.GetLength(1); col++)
                {
                    square[row, col] = input[col];
                }
            }
            int leftSum = 0;
            int rightSum = 0;

            for (int row = 0; row < square.GetLength(0); row++)
            {
                
                    leftSum += square[row, row];
                    rightSum += square[row, ((n-1) - row)];
                
            }
            int difr = Math.Abs(leftSum - rightSum);
            Console.WriteLine(difr);
        }
    }
}
