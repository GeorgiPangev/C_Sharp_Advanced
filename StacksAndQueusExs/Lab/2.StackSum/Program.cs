using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <input.Length; i++)
            {
                stack.Push(int.Parse(input[i]));
            }
            string[] comand = Console.ReadLine().ToLower()
                .Split() 
                .ToArray();
            while (comand[0]!="end")
            {
                if (comand[0]=="add")
                {
                    for (int i = 1; i < comand.Length; i++)
                    {
                        stack.Push(int.Parse(comand[i]));
                    }

                }
                else if (comand[0]== "remove")
                {
                    if (int.Parse(comand[1])<stack.Count)
                    {
                        for (int i = 0; i < int.Parse(comand[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                        
                    
                }
                comand = Console.ReadLine()
                    .ToLower()
               .Split()
               .ToArray();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
