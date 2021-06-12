using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../../TestFolder");
            long count = 0;
            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                count += info.Length;
            }

            count = count / 1024 / 1024;
           File.WriteAllText("../../../ Output.txt",$"{count.ToString()}");
            
        }
	

	
    }
}
