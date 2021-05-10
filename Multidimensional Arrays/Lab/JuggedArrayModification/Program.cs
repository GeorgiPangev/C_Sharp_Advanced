using System;
using System.Linq;

namespace JuggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jugged = new int[n][];

            for (int row = 0; row < jugged.GetLength(0); row++)
            {
                
                int[] inp = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jugged[row] = new int[inp.Length];
                for (int col = 0; col < inp.Length; col++)
                {
                    jugged[row] [col] = inp[col];
                  
                }
                
            }
            int index = jugged[0].Length;

            string[] input = Console.ReadLine().Split();
            while (input[0]!="END")
            {
                int r = int.Parse(input[1]);
                int c = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                bool isValid = IsValid(jugged, r, c);
                if (!isValid)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (input[0]== "Add"&&isValid)
                {
                    jugged[r][c] += value;
                    
                }
                else if (input[0]== "Subtract"&& isValid)
                {
                    jugged[r][c] -= value;
                    
                }
                input = Console.ReadLine().Split();
            }
            for (int i = 0; i < jugged.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", jugged[i]));
            }
        }
        private static bool IsValid(int[][] jagg, int r, int c)
        {
            if ((r>=0&&r<jagg.GetLength(0))&&(c>=0&&c<jagg[r].Length))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
