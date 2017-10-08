using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[] { 22, 45, 12, 8, 10, 6, 72, 81, 33, 18, 50, 14 };
            double[,] buckets = new double[10, 10];
            int j = 0;

            //gets divider
            double divider = Math.Ceiling((arr[7] + 1) / 10);

            //gets bucket index
            for (int i = 0; i < arr.Length; i++)
            {
                j = (int) Math.Floor(arr[i] / divider);
                buckets[j, 0] = arr[i];
                //Console.WriteLine(arr[i] + " on j: " + j);
                
            }
            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine("Array: " + buckets[c, 0]);
            }

            //Console.WriteLine(buckets[Convert.ToInt32(j), 0]);

            //bucket
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                }
            }

            Console.ReadKey();
        }
    }
}
