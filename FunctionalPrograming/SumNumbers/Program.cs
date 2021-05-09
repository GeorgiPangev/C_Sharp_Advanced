using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

           Action<int> print = n => Console.WriteLine(n);
            //Func<int[], string> print = p => p.ToString(); 
           Check(input, print);
        }

        private static void Check(int[] input, Action<int> print)
        {
            print(input.Length);
            print(input.Sum());
        }
    }
}
