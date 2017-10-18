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
            double[,] buckets = new double[10, 12];
            int j = 0,
                column = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                j = (int) arr[i] % 10;
                if (buckets[j, column] != 0)
                {
                    for (int cNum = 0; buckets[j, column] != 0; cNum++)
                    {
                        column++;
                    }
                    buckets[j, column] = arr[i];
                    column = 0;
                }
                else
                {
                    buckets[j, column] = arr[i];
                }
                Console.WriteLine(arr[i] + ": " + j);
            }
            Console.WriteLine("Final array");
            for (int c = 0; c < 10; c++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(buckets[c, y] + "\t");
                }
                Console.WriteLine("\n");
            }

            //final output
            

            Console.ReadKey();
        }
    }
}
