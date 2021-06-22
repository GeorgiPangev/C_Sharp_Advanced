using System;
using System.IO;

namespace CopiBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream reader = new FileStream("copyMe.png", FileMode.Open, FileAccess.Read);
            using FileStream writer = new FileStream("../../../Output.png",  FileMode.Create, FileAccess.Write);

            while (reader.Position< reader.Length)
            {
                byte[] bufer = new byte[4096];
                reader.Read(bufer, 0, bufer.Length);
                writer.Write(bufer);
            }
        }
    }
}
