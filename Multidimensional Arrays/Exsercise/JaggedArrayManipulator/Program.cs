using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jug = new double[rows][];
            for (int i = 0; i < jug.GetLength(0); i++)
            {
                double[] inp = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                jug[i] = inp;
            }

            for (int row = 0; row < jug.GetLength(0)-1; row++)
            {
                if (jug[row].Length== jug[row+1].Length)
                {
                    jug = Multiplaier(jug, row);
                    jug = Multiplaier(jug, row+1);
                }
                else
                {
                    jug = Divider(jug, row);
                    jug = Divider(jug, row + 1);
                }
            }

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            while (input[0]!= "End")
            {
                int ro = int.Parse(input[1]);
                int co = int.Parse(input[2]);
                if (input[0]== "Add"&& Validator(jug, ro, co) )
                {
                    jug[ro][co] += double.Parse(input[3]);
                }
                else if (input[0] == "Subtract" && Validator(jug, ro, co))
                {
                    jug[ro][co] -= double.Parse(input[3]);
                }
                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }



            foreach (var item in jug)
            {
                Console.WriteLine(string.Join(" ", item));
            };
        }

        private static bool Validator(double[][] jug, int ro, int co)
        {
            
            return ro >= 0 && ro < jug.GetLength(0) && co >= 0 && co < jug[ro].Length; 
        }

        private static double[][] Divider(double[][] jug, int row)
        {
            jug[row] = jug[row]
               .Select(x => x / 2)
               .ToArray();
            return jug;
        }

        private static double[][] Multiplaier(double[][] jug, int row)
        {
            jug[row] = jug[row]
                .Select(x => x * 2)
                .ToArray();
            return jug;

        }
    } 
}
