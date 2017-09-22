using System;
using System.IO;
/*
    H:\


     */

namespace DirectoryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine("The current directory: \n{0}\n",
                Directory.GetCurrentDirectory());
            Console.WriteLine("File Name".PadRight(52) + "Size".PadRight(10) + 
                "Creation Time");
            foreach (FileInfo fil in dir.GetFiles("*.*"))
            {
                string name = fil.Name;
                long size = fil.Length;
                DateTime creationTime = fil.CreationTime;
                Console.WriteLine("{0} {1,12:N0}{2,20:g}",
                    name.PadRight(45),
                    size,
                    creationTime);
            }
            Console.Read();
        }
    }
}
