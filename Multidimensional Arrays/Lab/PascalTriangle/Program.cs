using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ulong[][] piramid = new ulong[n][];

            for (int row = 0; row < piramid.GetLength(0); row++)
            {
                piramid[row] = new ulong[row + 1];

                for (int col = 0; col < piramid[row].Length; col++)
                {
                    if (col==0||col==piramid[row].Length-1)
                    {
                        piramid[row][col] = 1;
                    }
                    else 
                    {
                        piramid[row][col] = piramid[row - 1][col - 1] + piramid[row - 1][col];
                    }
                }
            }

            foreach (ulong[] row in piramid)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
