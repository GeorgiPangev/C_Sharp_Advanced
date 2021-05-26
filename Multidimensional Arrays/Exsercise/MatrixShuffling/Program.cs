using System;
using System.Linq;

namespace MatrixShuffling
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

            string[,] matrix = new string[dim[0], dim[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }

            }
            string[] comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (comand[0]!="END")
            {
                if (comand.Length== 5)
                {
                    if (IsValid(comand, x, y))
                    {
                        int rowOne = int.Parse(comand[1]);
                        int colOne = int.Parse(comand[2]);
                        int rowTwo = int.Parse(comand[3]);
                        int colTwo = int.Parse(comand[4]);

                        string first = matrix[rowOne, colOne];
                        matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                        matrix[rowTwo, colTwo] = first;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {

                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col]+" ");
                            }
                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            }

        }

        private static bool IsValid(string[] comand, int x, int y)
        {
            int rowOne = int.Parse(comand[1]);
            int colOne = int.Parse(comand[2]);
            int rowTwo = int.Parse(comand[3]);
            int colTwo = int.Parse(comand[4]);

            return (rowOne >= 0 && rowOne < x) && (colOne >= 0 && colOne < y)
                && (rowTwo >= 0 && rowTwo < x) && (colTwo >= 0 && colTwo < y);

        }
    }
}
