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

        public int Sort()
        {
            /* ***************************************** *
             * Placeholder used to hold rightmost digits *
             * ***************************************** */
            int[] placeholder = new int[numLength];
            
            for (int i = 0; i < 10; i++)
            {
                
                for (int x = 0; x < 10; x++)
                {

                }
            }
            return 1;
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
