using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader
                (@"D:\C#\Advanced\Streams,FilesandDirectories\Lab\Streams,FilesandDirectories\OddLines\input.txt");
            int counter = 0;
            using (reader)
            {
                string line = reader.ReadLine();
                using (StreamWriter write = new StreamWriter
                    (@"D:\C#\Advanced\Streams,FilesandDirectories\Lab\Streams,FilesandDirectories\OddLines\Output.txt"))
                {
                    while (line!=null)
                    {
                       
                        if (counter % 2 == 1)
                        {
                            write.WriteLine(line);
                            Console.WriteLine("+++");
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
