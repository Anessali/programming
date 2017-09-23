using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class AutoLoan : Loan
    {
        protected decimal downPayment;
        public AutoLoan(decimal downPayment, int loanID, DateTime dueDate, decimal balance,
            decimal interestRate, int monthTerms)
            : base(loanID, dueDate, balance, interestRate, monthTerms)
        {
            this.downPayment = downPayment;
        }

        /// <summary>
        /// Base method is overridden so down payment 
        /// can be subtracted
        /// </summary>
        /// <returns></returns>
        public override decimal CalculatePayment()
        {
            decimal monthlyRate = CalculateInterest();
            decimal paymentAmount = balance + monthlyRate - downPayment;
            return paymentAmount;
        }
        public decimal DownPayment { get; set; }
    }
}