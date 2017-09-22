using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int numOne = 0;
            int numTwo = 0;
            string var;

            //calculations
            var = Console.ReadLine();
            int.TryParse(var, out numOne);
            numTwo = numOne * 2;

            //Output
            Console.Write("The number is: {0}", numTwo);
            Console.ReadLine();
        }
    }
}
