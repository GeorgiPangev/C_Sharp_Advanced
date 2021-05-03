using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = x=> Console.WriteLine(string.Join(Environment.NewLine, x));
            Func<double, double> vat = d => (d += d * 0.2);
            Func<double, string> f = n => $"{n:F2}";
            string[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => vat(n))
                .Select(b=>f(b))
                .ToArray();

            print(prices);
        }
    }
}
