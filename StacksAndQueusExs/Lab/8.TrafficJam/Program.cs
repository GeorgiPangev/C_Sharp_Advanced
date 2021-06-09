using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pasedCars = 0;
            Queue<string> cars = new Queue<string>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                if (input=="green")
                {
                    if (cars.Count>=n)
                    {
                        for (int i = 0; i < n; i++)

                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            pasedCars++;
                        }
                    }
                    else
                    {
                        for (int i = cars.Count-1; i>=0; i--)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            pasedCars++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();

            }

            Console.WriteLine($"{pasedCars} cars passed the crossroads.");

        }
    }
}
