using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared variables
            int[] myArray = new int[] { 100, 20, 1, 600, 300, 33, 71, 92 };


            /* ****************************************** *
             * Counts array before it is sorted by bubble *
             * ****************************************** */
            Console.Write("The original order is: ");
            int i = 0; //i declared outside of for to remove comma
            for (i = 0; i < (myArray.Length - 1); i++)
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine(myArray[i]);

            BubbleSort(myArray);

            Console.ReadKey();
        }

        private static int[] BubbleSort(int[] myArray)
        {
            for (int i= 0; i < myArray.Length; i++)
            {
                for (int x = 0; x < myArray.Length; x++)
                {

                }
            }

            return myArray;
        }
    }
}