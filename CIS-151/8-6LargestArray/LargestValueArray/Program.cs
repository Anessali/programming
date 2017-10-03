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
            bool exitVar = false;
            //exitVar is used to loop program if user enters invalid data
            while (exitVar == false)
            {
                try
                {
                    Console.WriteLine("Enter number of rows: ");
                    rows = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of columns: ");
                    columns = Convert.ToInt32(Console.ReadLine());
                    ArrayGen(rows, columns);
                    exitVar = true; 
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.ReadKey();
        }//end of main

        /// <summary>
        /// Method uses input data to generate
        /// and output multidimensional array
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public static void ArrayGen(int rows, int columns)
        {
            int[,] randArray = new int[rows, columns];
            int length = randArray.Length;
            randArray[0, 1] = 1;
            Random num = new Random();
            Console.Write("\nIndex\n");
            for (int x = 0; x < rows; x++)
            {
                Console.Write(x);
                for (int o = 0; o < columns; ++o)
                {
                    randArray[x, o] = num.Next(0, 100);
                    Console.Write("\t" + randArray[x,o]);
                }
                Console.WriteLine();
            }
            /*~    below code prints out array    ~*/
            
        }
    }
}
