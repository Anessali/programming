using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      Declared variables      */
            Random rand = new Random();
            
            int[] nums = new int[100];
            int length = nums.Length;
            int rows = 10,
                columns = 100;
            int[,] bucket = new int[rows, columns + 1];
            
            //nums array is filled with random numbers
            Console.WriteLine("The unsorted array is: ");
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 500);
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine();
            BucketSort pail = new BucketSort(nums, bucket, length);
            nums = pail.Sort();

            /*~~~   Output   ~~~*/
            Console.WriteLine("First pass through bucket: \n");
            pail.printNums(nums);

            Console.ReadKey();
        }//end of main

        

        /// <summary>
        /// Generates program dots
        /// </summary>
        /// <param name="dots"></param>
        public void dot()
        {
            int dots = 10;
            for (int i = 0; i < dots; i++)
            {
                Console.WriteLine(".");
            }
        }
    }
}
