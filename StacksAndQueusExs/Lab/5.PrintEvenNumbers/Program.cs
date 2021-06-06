using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           // string inp = Console.ReadLine();
            Queue<int> queue = new Queue<int>(new List<int>(Console.ReadLine().Split()
                .Select(int.Parse).Where(x => x % 2 == 0)
                .ToList()));
            if (queue.Any())
            {
                //while (queue.Any())
                //{
                //    Console.Write($"{queue.Dequeue()}, ");
                //}
                Console.WriteLine(string.Join(", ",queue));
            }
        }
    }
}
