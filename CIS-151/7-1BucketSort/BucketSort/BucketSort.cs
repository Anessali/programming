using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class BucketSort
    {
        private int[] nums;
        private int[,] bucket;
        private int numLength;

        public BucketSort(int[] nums, int[,] bucket, 
            int numLength)
        {
            this.nums = nums;
            this.bucket = bucket;
            this.numLength = numLength;
        }

        public int[] Sort()
        {
            Program prog = new Program();
            /* ***************************************** *
             *         Bucket Sort is executed           *
             * ***************************************** */
            int mod = 0,
                column = 0,
                count = 0;

            //vlaues in num array added to buckets
            for (int i = 0; i < nums.Length; i++)
            {
                mod = nums[i] % 10;
                if (bucket[mod, column] != 0)
                {
                    for (int cNum = 0; bucket[mod, column] != 0; cNum++)
                    {
                        column++;
                    }
                    bucket[mod, column] = nums[i];
                    column = 0;
                }
                else
                {
                    bucket[mod, column] = nums[i];
                }
            }
            
            prog.dot();
            printBucket(bucket);
            prog.dot();

            //buckets are emptied into nums array
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++) {
                    nums[count] = bucket[r, c];
                    count++;
                }
                
            }
            return nums;
        }//end of Sort()

        /// <summary>
        /// prints nums array
        /// </summary>
        /// <param name="nums"></param>
        public void printNums(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }
        }

        /// <summary>
        /// method prints two-dimensional array
        /// </summary>
        public static void printBucket(int [,] bucket)
        {
            for (int r = 0; r < 10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                    Console.Write(bucket[r, c] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        #region getters/setters
        public int[] Nums
        {
            get { return nums; }
            set { nums = value; }
        }
        public int[,] Bucket
        {
            get { return bucket; }
            set { bucket = value; }
        }
        public int NumLength
        {
            get { return numLength; }
            set { numLength = value; }
        }
        #endregion
    }//end of BucketSort class
}
