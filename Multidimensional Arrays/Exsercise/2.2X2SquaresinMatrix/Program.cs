using System;
using System.Linq;

namespace _2._2X2SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[dim[0], dim[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                    
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    char a = matrix[row, col];
                    char b = matrix[row, col + 1];
                    char c = matrix[row + 1, col];
                    char d = matrix[row + 1, col + 1];
                    if ((matrix[row, col]== matrix[row,col+1])&&
                        (matrix[row+1, col]==matrix[row+1, col+1])&&
                        matrix[row, col]==matrix[row+1, col+1])
                    {
                        counter++;
                    }

                }
            }
            Console.WriteLine(counter);
        }
    }
}
