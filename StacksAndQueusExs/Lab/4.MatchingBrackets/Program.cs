using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] ==')' )
                {
                    stack.Push(i);
                    int end = stack.Pop();
                    int start = stack.Pop();
                    string sub = input.Substring(start, (end+1 - start));
                    Console.WriteLine(sub);
                }
            }
        }
    }
}
