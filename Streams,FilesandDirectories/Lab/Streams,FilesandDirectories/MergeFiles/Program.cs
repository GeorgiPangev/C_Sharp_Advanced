using System;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readOne = new StreamReader("../../../FileOne.txt");
            StreamReader readTwo = new StreamReader("../../../FileTwo.txt");
            StreamWriter write = new StreamWriter("../../../Output.txt");
            using (readTwo)
            {
                using (readOne)
                {
                    string lineOne = readOne.ReadLine();
                    string lineTwo = readTwo.ReadLine();
                    
                    while (readOne!=null||readTwo!=null)
                    {
                        write.WriteLine(lineOne);
                        write.WriteLine(lineTwo);
                        lineOne = readOne.ReadLine();
                        lineTwo = readTwo.ReadLine();
                    }

                }
            }
        }
    }
}
