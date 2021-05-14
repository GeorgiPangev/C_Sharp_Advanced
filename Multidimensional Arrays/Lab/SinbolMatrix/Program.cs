using System;
using System.Linq;

namespace SinbolMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char ch = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col]== ch)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{ch} does not occur in the matrix ");
            }

            
        }
    }
}
