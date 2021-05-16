using System;
using System.Linq;

namespace SqaureWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dim[0], dim[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                }
            }
            int maxSum = int.MinValue;
            int ultr = 0;
            int urtr = 0;
            int lltr = 0;
            int lrtr = 0;

            for (int row = 1; row <= matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int ul = matrix[row, col];
                    int ur = matrix[row, col + 1];
                    int ll = matrix[row - 1, col];
                    int lr = matrix[row - 1, col + 1];
                    int sum = ul + ur + ll + lr;
                    if (maxSum< sum)
                    {
                        maxSum = sum;
                         ultr = matrix[row, col]; ;
                         urtr = matrix[row, col + 1];
                         lltr = matrix[row - 1, col];
                         lrtr = matrix[row - 1, col + 1];
                    }
                }
            }
            
            Console.WriteLine($"{lltr} {lrtr}");
            Console.WriteLine($"{ultr} {urtr}");
            Console.WriteLine(maxSum);


        }
    }
}
