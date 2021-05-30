using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            int counter = 0;

            char[,] matrix = new char[dim[0], dim[1]];

            for (int row = 1; row <= dim[0]; row++)
            {
                if (row % 2 == 1)
                {
                    for (int col = 0; col < dim[1]; col++)
                    {
                        matrix[row-1, col] = snake[counter];
                        counter = CounterChang(counter, snake.Length);
                    }
                    
                   
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >=0 ; col--)
                    {
                        matrix[row-1, col] = snake[counter];
                        counter = CounterChang(counter, snake.Length);
                    }
                }
             
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }


        }

        private static int CounterChang(int counter, int length)
        {
            counter++;
            if (counter == length)
            {
                counter = 0;
            }
            return counter;

        }
    }
}
