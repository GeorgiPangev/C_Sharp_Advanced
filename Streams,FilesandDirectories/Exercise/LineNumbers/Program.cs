using System;
using System.Collections.Generic;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<string> lines = new 
            using (StreamReader reader = new StreamReader(@"../../../text.txt"))//FileMode.Open, FileAccess.Read))
            {
                using (StreamWriter write = new StreamWriter(@"../../../Output.txt"))//FileMode.Create))
                {
                    //string line = reader.ReadLine().ToString();
                    int lineCount = 0;
                    string line = reader.ReadLine();
                    while (reader!=null)
                    {
                        if (reader==null)
                        {
                            break;
                        }
                        //string line = reader.ReadLine();
                        int lethersCount = 0;
                        int pointsCount = 0;
                        lineCount++;
                        for (int i = 0; i < line.Length ; i++)
                        {
                            if (char.IsLetter(line[i]))
                            {
                                lethersCount++;
                            }
                            else if (char.IsPunctuation(line[i]))
                            {
                                pointsCount++;
                            }

                        }
                        string print = $"Line-{lineCount}: {line} ({lethersCount})({pointsCount})";
                        write.WriteLine(print);
                        if (reader.EndOfStream)
                        {
                            break;
                        }
                        line = reader.ReadLine();
                       

                    }
                }
            }

        }
    }
}
