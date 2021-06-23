using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversial
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] filesList = Directory.GetFiles(path);
            Dictionary<string, Dictionary<string, double>> 
                filesData = new Dictionary<string, Dictionary<string, double>>();
            foreach (string file in filesList)
            {
                FileInfo f = new FileInfo(file);
                string type = f.Extension;
                double size = (double)(f.Length / 1024);
                if (!filesData.ContainsKey(type))
                {
                    filesData.Add(type, new Dictionary<string,double>());

                }
                filesData[type].Add(f.Name , size);
            }
            Dictionary<string, Dictionary<string, double>> sorted = filesData
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(k => k.Key)
                .ThenBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            List<string> print = new List<string>();
            foreach ( var item in sorted)
            {
                print.Add($"{item.Key}:");
                foreach (var file in item.Value)
                {
                    print.Add($"{file.Key} - {file.Value}kb");
                }
            }
            string pathDeskc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Output.txt");
            File.WriteAllLines(pathDeskc, print);
        }
    }
}
