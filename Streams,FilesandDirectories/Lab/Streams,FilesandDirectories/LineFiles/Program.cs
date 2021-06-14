using System;
using System.IO;

namespace LineFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            using (StreamReader read = new StreamReader(@"../../../input.txt"))
            {
                string line = read.ReadLine();
                using (StreamWriter write = new StreamWriter(@"../../../Output.txt"))
                {
                    while (line!=null)
                    {
                        counter++;
                        write.WriteLine($"{counter}, {line}");
                        line = read.ReadLine();
                    }
                    
                }
            }
            

        }
    }
}
