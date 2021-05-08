using System;
using System.Collections.Generic;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n=>n%2==0)
                .OrderBy(x => x)
               .Select(n=> n.ToString())
                //.Where(n =>char.IsDigit(char.Parse(n))
                .ToArray();

            Action <string[]> print = input => Console.WriteLine(string.Join(", ", input));
            print(input);
            
            
            //input = input.Select(x=>x.print(x));

        }
    }
}
