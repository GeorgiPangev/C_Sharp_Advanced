using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> childrens = new Queue<string>(Console.ReadLine()
                .Split()
                .ToArray());
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (childrens.Count>1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    childrens.Enqueue(childrens.Dequeue());
                }
                Console.WriteLine(childrens.Dequeue());
            }
            Console.WriteLine($"Last is {childrens.Dequeue()}");


        }
    }
}
