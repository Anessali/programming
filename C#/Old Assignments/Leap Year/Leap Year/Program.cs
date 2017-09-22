using System;
using static System.Console;

/*
    Name:   TJ Liggett
    Project:Leap Year
    Date:   3/22/2017
     */

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredYear = ""; //must be declared for while loop
            Write("Please enter a year (-1 to quit): \n");
            enteredYear = ReadLine(); //ends while loop if -1 is entered
            while (enteredYear != "-1")
            {
                int year = GetYear(enteredYear);
                int modFour = GetModFour(year);
                int modHundred = GetModHundred(year);
                int modFourHundred = GetModFourHundred(year);
                CalculateResults(year, modFour, modHundred, modFourHundred);
                Write("Please enter a year (-1 to quit): \n");
                enteredYear = ReadLine(); //ends while loop if -1 is entered
            }
        }
        //gets user input for the year
        public static int GetYear(string enteredYear)
        {
            int year;
            while (int.TryParse(enteredYear, out year) == false)
            {
                Write("Invalid input. Please enter a year (-1 to quit): \n");
                enteredYear = ReadLine();
            }
            //year = Convert.ToInt32(enteredYear);
            return year;
        }
        //calculates modulus 4 for leap year
        static int GetModFour(int year)
        {
            int modFour;
            modFour = year % 4;
            return modFour;
        }
        //calculates modulus 100 for leap year
        static int GetModHundred(int year)
        {
            int modHundred;
            modHundred = year % 100;
            return modHundred;
        }
        //calculates modulus 400 for leap year
        static int GetModFourHundred(int year)
        {
            int modFourHundred;
            modFourHundred = year % 400;
            return modFourHundred;
        }
        //calculates end results
        static void CalculateResults(int year, int modFour, int modHundred, int modFourHundred)
        {
            #region modulo if statements
            WriteLine("Year entered: {0}", year);
            //for modulo 4
            Write("Divisible by 4: ");
            if (modFour == 0)
            {
                WriteLine("Yes");
            }
            else
            {
                WriteLine("No");
            }
            //for modulo 100
            Write("Divisible by 100: ");
            if (modHundred == 0)
            {
                WriteLine("Yes");
            }
            else
            {
                WriteLine("No");
            }
            //for modulo 400
            Write("Divisible by 400: ");
            if (modFourHundred == 0)
            {
                WriteLine("Yes");
            }
            else
            {
                WriteLine("No");
            }
            #endregion
            Write("Leap year: ");
            if (modFour == 0 && modHundred != 0)
            {
                WriteLine("Yes");
            }
            else if (modHundred == 0 && modFourHundred == 0)
            {
                WriteLine("Yes");
            }
            else
            {
                WriteLine("No");
            }
        }
    }
}