using System;
using System.Linq;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int x = dim[0];
            int y = dim[1];

            int[,] matrix = new int[x, y];
            for (int row = 0; row < x; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < y; col++)
                {
                    matrix[row, col] = input[col];
                }

            }
            bool isValid = true;
            int maxSum = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;
            if (matrix.GetLength(0) < 3 || matrix.GetLength(1) < 3)
            {
                isValid = false;
            }
            else
            {

                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        int newSumOne = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                        int newSumTwo = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                        int newSumTree = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                        int sum = newSumOne + newSumTwo + newSumTree;
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxRow = row;
                            maxCol = col;

                        }
                    }


                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            if (isValid)
            {
                for (int row = maxRow; row <= maxRow + 2; row++)
                {
                    for (int col = maxCol; col <= maxCol + 2; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
