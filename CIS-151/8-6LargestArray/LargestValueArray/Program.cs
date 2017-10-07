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
            int rows = 0;
            int columns = 0;
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
                    exitVar = true;


                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            ArrayGen(rows, columns);
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
            //declared variables
            int[,] randArray = new int[rows, columns];
            String largerValue = "";

            Random num = new Random();
            int[,] largestNum = new int[rows, columns]; //used to hold largest value in array
            /*~     Index Menu     ~*/
            Console.Write("\nIndex");
            for (int i = 0; i < columns; i++)
            {
                Console.Write("\t" + i);
            }
            /*~     Outputs multidimensional array     ~*/
            Console.WriteLine();
            for (int x = 0; x < rows; x++)
            {
                Console.Write(x);
                for (int o = 0; o < columns; ++o)
                {
                    randArray[x, o] = num.Next(0, 100);
                    Console.Write("\t" + randArray[x, o]);
                }
                Console.WriteLine();
            }
            //Nested for loops used to search for the largest value
            int biggestNum = 0;
            for (int y = 0; y < rows; y++)
            {
                for (int z = 0; z < columns; z++)
                {
                    if (randArray[y, z] > biggestNum)
                    {
                        biggestNum = randArray[y, z];
                        //larger value information is stored in string variable
                        largerValue = "\nThe largest value is " + randArray[y, z] +
                            " at index " + y + ", " + z;
                    }
                }
            }
            Console.WriteLine(largerValue);
        }//end of ArrayGen
    }
}

