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

        public BucketSort(int[] nums, int[,] bucket)
        {
            this.nums = nums;
            this.bucket = bucket;
        }
        
        public static void Sort()
        {

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
        #endregion
    }//end of BucketSort class
}
