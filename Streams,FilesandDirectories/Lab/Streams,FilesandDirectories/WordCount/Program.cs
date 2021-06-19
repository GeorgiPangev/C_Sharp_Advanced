using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            StreamReader reader = new StreamReader(@"../../../Words.txt");
            string lineWord = reader.ReadToEnd().ToLower().Replace(',', ' ');
            reader.Close();
            string[] arr = lineWord.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                words.Add(arr[i], 0);
            }

            //List<string> lin = new List<string>(); ;
            StreamReader text = new StreamReader(@"../../../Text.txt");
            string pattern = @"([A-Za-z]+\b)";
            using (text)
            {

                //for (int i = 0; i < arr.Length; i++)
                //{

                     string line = text.ReadToEnd().ToLower();
                    //while (line != null)
                    //{
                        Regex reg = new Regex(pattern);
                        MatchCollection matches =reg.Matches(line);
                        foreach (Match mach in matches)
                        {
                            if (words.ContainsKey(mach.Value))
                            {
                                words[mach.Value]++;
                            }
                           
                        }
                //line = text.ReadLine();
                //}
                //}
                using (StreamWriter write = new StreamWriter(@"../../../Output.txt"))         
                    foreach (var item in words.OrderByDescending(x => x.Value))
                    {
                        write.WriteLine($"{item.Key} - {item.Value}");
                        //Console.WriteLine($"{item.Key}- {item.Value}");
                    }
            }

            

                
        }
    }
}
