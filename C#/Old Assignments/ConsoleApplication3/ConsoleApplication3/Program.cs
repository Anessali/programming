using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //I don't understand why my program isn't working.

            // It's supposed to multiply the two numbers entered, but it doesn't work. I enter the first number, 
            // enter the second, press enter... and it displays the first number.
            
            //All I can think is maybe there's something wrong with a variable.
            
            int numOne = Convert.ToInt32(Console.ReadLine());
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int numThree = numOne * numTwo;
            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(".");
            }
            //Oh wait, I put the wrong variable in the IF statement
            if (numOne >= 0 && numTwo >= 0)
            {
                Console.WriteLine(numOne); //incorrect: numOne - correct: numThree
            }
            //It works!
            Console.ReadKey();
        }
    }
}