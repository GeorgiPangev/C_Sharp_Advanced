using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] comands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[n, n];

            int sRow = -1;
            int sCol = -1;
            int allCoils = 0;


            for (int row = 0; row <matrix.GetLength(0) ; row++)
            {
                char[] input =Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 's') 
                    {
                        sRow = row;
                        sCol = col;
                    }
                    else if (matrix[row, col] == 'c')
                    {
                        allCoils++;
                    }
                }
            }
            bool isOver = false;
            int coilsCount = 0;
            for (int i = 0; i < comands.Length; i++)
            {
                if (comands[0]== "left" && IsValid(matrix, sRow,sCol -1))
                {
                    matrix[sRow, sCol] = '*';
                    sCol -= 1;
                   // coilsCount = Is
                    if (matrix[sRow, sCol]=='c')
                    {
                        coilsCount++;
                        matrix[sRow, sCol] = 's';
                    }
                    else if (matrix[sRow,sCol]== 'e')
                    {
                        isOver = true;
                        break;
                    }

                }
                else if (comands[0] == "right" && IsValid(matrix, sRow, sCol - 1))
                {
                    matrix[sRow, sCol] = '*';
                    sCol += 1;
                    // coilsCount = Is
                    if (matrix[sRow, sCol] == 'c')
                    {
                        coilsCount++;
                        matrix[sRow, sCol] = 's';
                    }
                    else if (matrix[sRow, sCol] == 'e')
                    {
                        isOver = true;
                        break;
                    }

                }
                else if (comands[0] == "up" && IsValid(matrix, sRow, sCol - 1))
                {
                    matrix[sRow, sCol] = '*';
                    sRow += 1;
                    // coilsCount = Is
                    if (matrix[sRow, sCol] == 'c')
                    {
                        coilsCount++;
                        matrix[sRow, sCol] = 's';
                    }
                    else if (matrix[sRow, sCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({sRow}, {sCol})");
                        isOver = true;
                        break;
                    }

                }
                if (isOver)
                {
                    break;
                }
                else if (coilsCount== allCoils)
                {
                    Console.WriteLine($"You collected all coals! ({sRow}, {sCol})");
                }
                
            }


        }

        private static bool IsValid(char[,] matrix, int r, int c)
        {
            return r >= 0 && r < matrix.GetLength(0) && c >= 0 && c < matrix.GetLength(1);
        }
    }
}
