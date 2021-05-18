using System;
using System.Linq;

namespace SumMatrixElement
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] dim = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int r = dim[0];
            int c = dim[1];

            int[,] matrix = new int[r, c];

            


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
                for (int cow = 0; cow < matrix.GetLength(1); cow++)
                {
                    matrix[row, cow] = input[cow];
                }

               

            }

            int sum = 0;

            foreach (int item in matrix)
            {
                sum += item;
            }
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        sum += matrix[row, col];
            //    }
            //}
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
