using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Application randomly generates
 * numbers in a two-dimensional 
 * array
 */
namespace LargestValueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int columns;
            int randomNum;
            bool exitVar = false;
            while (exitVar == false)
            {
                try
                {   
                    Console.WriteLine("Enter number of rows: ");
                    rows = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of columns: ");
                    columns = Convert.ToInt32(Console.ReadLine());
                    int[,] randArray = new int[rows, columns];
                    Console.WriteLine(randArray[10, 0]);

                    exitVar = true;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.ReadKey();
        }
    }
}
