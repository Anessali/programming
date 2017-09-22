using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*==============================
 *          TJ Liggett
 *          Exam 1
 *          CIS-151
 * =============================*/
namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            DateTime today = new DateTime(); //sets DateTime
            //user input gathered
            Console.WriteLine("What is your client's name? ");
            string clientName = Console.ReadLine();
            Console.Write("Enter loan ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter balance due: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter interest rate: ");
            decimal interest = Convert.ToDecimal(Console.ReadLine());

            //new class created using gathered input
            Loan newLoan = new Loan(id, today, balance, interest, 0);

            Console.WriteLine(Loan.ToString());

            Console.ReadKey(); //keeps program open after running
        }
    }
}
