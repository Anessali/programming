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
            int[,] bucket = new int[10, 10];
            int length = nums.Length;

            //nums array is filled with random numbers
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(0, 100);
            }

            BucketSort pail = new BucketSort(nums, bucket, length);

            Console.ReadKey();
        }
    }
}
