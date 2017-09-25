using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_Calories_102
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randArray = new Random();
            int[,] calories = new int [7, 3];

            for (int x = 0; x < calories.GetLength(0); x++)
            {
                for (int i = 0; i < calories.GetLength(1); i++)
                {
                    calories[x, i] = randArray.Next(0, 1000);
                }
            }
            
            ////allocate a two dimensional array
            //int[ , ] calories = { { 900,  750, 1020 },
            //                    { 300, 1000, 2700 },
            //                    { 500,  700, 2100 },
            //                    { 400,  900, 1780 },
            //                    { 600, 1200, 1100 },
            //                    { 575, 1150, 1900 },
            //                    { 600, 1020, 1700 }};
            double[] dailyAverage = new double[7];
            double[] mealAverage = new double[3];
            dailyAverage = CalculateAverageByDay(calories);
            mealAverage = CalculateAverageByMeal(calories);
            Console.ReadKey();
        }

        public static double[] CalculateAverageByDay(int[ , ] calories)
        {
            int sum = 0;
            double[] dailyAverage = new double[7];
            //outer for loop - walk the days
            for (int r = 0; r < calories.GetLength(0); r++)
            {
                //inner for loop - walk the meals (columns)
                for (int c = 0; c < calories.GetLength(1); c++)
                {
                    sum += calories[r, c];
                } // end of inner loop
                dailyAverage[r] = (double) sum / calories.GetLength(1);
                sum = 0;
            }//end of outer loop
            return dailyAverage;
        }

        public static double[] CalculateAverageByMeal(int[ , ] calories)
        {
            int sum = 0;
            double[] mealAverage = new double[3];

            //outer for loop - walk the columns
            for(int c = 0; c < calories.GetLength(1); c++)
            {
                //inner for loop - walk the rows
                for (int r = 0; r < calories.GetLength(0); r++)
                {
                    sum += calories[r, c];
                }//end of inner loop
                mealAverage[c] = (double)sum / calories.GetLength(0);
                sum = 0;
            }//end of outer loop
            return mealAverage;
        }
    }
}
