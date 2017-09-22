using System;
using System.IO;

namespace Ch13DirectoryStructure
{
    class Program
    {
        public enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            string fileName = "images/BirdOfParadise.jpg";

            if (File.Exists(fileName)) //runs if file exists
            {
                Console.WriteLine("Filname: {0}", fileName); //prints name
                Console.WriteLine("Attributes: {0}", File.GetAttributes(fileName)); //prints attributes
                Console.WriteLine("Created: {0}", File.GetCreationTime(fileName)); //prints creation time
                Console.WriteLine("CreatedUTC: {0}", File.GetCreationTimeUtc(fileName)); //prints creation time
                Console.WriteLine("Last Accessed: {0}", File.GetLastAccessTime(fileName));

            }
            else
            {
                Console.WriteLine("{0} not found - using current directory", fileName);
            }
            Console.WriteLine("Today is {0}", DayOfWeek.Wednesday);
            Console.WriteLine("{0} = {1}", DayOfWeek.Wednesday, (int)DayOfWeek.Wednesday);
            
            Console.Read();
        }
    }
}
