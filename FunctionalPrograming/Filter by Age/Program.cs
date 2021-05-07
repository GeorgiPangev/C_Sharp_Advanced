using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, int> parser = n => int.Parse(n);
            List<Peoples> newMen = new List<Peoples>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
                Peoples men =  new Peoples(input[0], parser(input[1]));
                newMen.Add(men);
            }
        }
    }
    class Peoples
    {
        public Peoples(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age{ get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
