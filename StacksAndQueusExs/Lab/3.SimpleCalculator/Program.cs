using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Stack<string> stack = new Stack<string>(input.Reverse());
            while (stack.Count>=3)
         
            {
                int x = int.Parse(stack.Pop());
                string doThis = stack.Pop();
                int y = int.Parse(stack.Pop());
                if (doThis== "+")
                {
                    x += y;
                    stack.Push(x.ToString());
                }
                else if (doThis=="-")
                {
                    stack.Push((x -= y).ToString());
                }
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
