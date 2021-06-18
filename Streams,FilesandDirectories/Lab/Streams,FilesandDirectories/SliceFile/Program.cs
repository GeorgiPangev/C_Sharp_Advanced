using System;
using System.Collections.Generic;
using System.IO;

namespace SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream reader = new FileStream
                ("../../../sliceMe.txt", FileMode.Open ,FileAccess.Read);
            //FileStream write = new FileStream(($"../../../Text{i}.txt"), FileAccess.Write, FileMode.OpenOrCreate);
            List<string> partsName = new List<string>
                { "Part-1.txt", "Part-2.txt", "Part-3.txt", "Part-4.txt" };
            int parts = 4;

            using (reader)
            {
                long priceSize = (long)Math.Ceiling((double)reader.Length / parts);
                

                byte[] bufer = new byte[4096];
               
                for (int i = 0; i < parts; i++)
                {
                    long curentPrice = 0;

                    using (FileStream write = new FileStream($"../../../{partsName[i]}", FileMode.OpenOrCreate))
                    {
                        while (reader.Read(bufer, 0, bufer.Length) > 0)//bufer.Length)
                        {
                            if (i==3&&reader.Length>bufer.Length )
                            {
                              
                                    write.Write(bufer, 0, bufer.Length);
                                   
                                
                            }
                            curentPrice += bufer.Length;
                            write.Write(bufer, 0 , bufer.Length);
                            if (curentPrice>=priceSize)
                            {
                                break;
                            }
                         }
                    }
                {

                }
                }
            }


        }
    }
}
