using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* -------------------------------
    This program sorts an array
    using the bubble sort method
    
    Note: I'm trying to improve 
    my commenting/readability
   ------------------------------- */
namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[100]; // { 100, 20, 1, 600, 300, 33, 71, 92 }
            Random rando = new Random();
            /*   Populates array with random numbers   */
            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rando.Next(1, 200);
            }
            double dots = 10; //edit this variable to change # of generated dots
            Console.Write("\nThe original order is: ");
            int i = 0; //i is declared outside of for to remove an extra comma
            for (i = 0; i < (myArray.Length - 1); i++)
            {
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine(myArray[i]); //see line 22 comment
            Dots(dots);
            myArray = BubbleSort(myArray);
            Dots(dots);
            // * Outputs final results *
            Console.Write("The sorted array: ");
            int y;
            for (y = 0; y < myArray.Length - 1; y++)
            {
                Console.Write(myArray[y] + ", ");
            }
            Console.WriteLine(myArray[y]);
            Console.ReadKey();
        }

        /// <summary>
        /// Method sorts generated array
        /// using bubble sort
        /// </summary>
        /// <param name="myArray"></param>
        /// <returns></returns>
        private static int[] BubbleSort(int[] myArray)
        {
            Console.WriteLine("Smaller\tLarger");
            Console.WriteLine("________________\n");
            int arrayHolder;
<<<<<<< HEAD
            // Original array: 100, 20, 1, 600, 300, 33, 71, 92
            for (int i = 0; i < myArray.Length; i++)
=======
            for (int i= 0; i < myArray.Length; i++)
>>>>>>> c37894b6c979bdde465234173b4a363fd454458e
            {
                for (int x = 0; x < myArray.Length - 1 - i; x++)
                {
                    if (myArray[x] > myArray[x + 1])
                    {
                        arrayHolder = myArray[x];
                        myArray[x] = myArray[x + 1];
                        myArray[x + 1] = arrayHolder;
                        Console.Write(myArray[x]);
                        Console.Write("\t");
                        Console.WriteLine(myArray[x + 1]);
                    }
                }
            }
            return myArray;
        }

        /// <summary>
        /// method prints dots
        /// for extra readability
        /// </summary>
        /// <param name="dot"></param>
        private static void Dots(double dot)
        {
            for (int i = 0; i < dot; i++)
            {
                Console.WriteLine(".");
            }
        }
    }
}
