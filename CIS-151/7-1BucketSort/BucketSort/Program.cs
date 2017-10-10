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
            Random rand = new Random();
            int[] nums = new int[100];
            int length = nums.Length;
            int rows = 10,
                columns = 100;
            int[,] bucket = new int[rows, columns];

            Console.WriteLine("\nPress enter to generate an unsorted array");
            Console.ReadLine();
            //nums array is filled with random numbers
            Console.WriteLine("The unsorted array is: ");
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 500);
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine();
            BucketSort pail = new BucketSort(nums, bucket, length);
            bucket = pail.Sort();
            for (int i = 0; i < 10; i++)
            {

                for (int x = 0; x < 10; x++)
                Console.Write(bucket[i, x] + "\t");
            }

            Console.ReadKey();
        }
    }
}
