using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Loan
    {
        //declared global variables
        protected string clientName;
        protected int loanID;
        protected DateTime dueDate;
        protected decimal balance;
        protected decimal interestRate;
        protected int monthTerms;

        public Loan(int loanID, DateTime dueDate, decimal balance,
            decimal interestRate, int monthTerms)
        {
            this.loanID = loanID;
            this.dueDate = dueDate;
            this.balance = balance;
            this.interestRate = interestRate;
            this.monthTerms = monthTerms;
        }
        /// <summary>
        /// Method adds thirty days to dueDate
        /// and converts to string
        /// </summary>
        /// <returns></returns>
        public string CalculateDueDate()
        {
            dueDate = DateTime.Now;
            string nextPayment = Convert.ToString(dueDate.AddDays(30).ToLongDateString());
            return nextPayment;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public decimal CalculateInterest()
        {
            decimal monthlyRate = balance * interestRate;
            return monthlyRate;
        }
        /// <summary>
        /// Calculates amount due at end of month
        /// </summary>
        public decimal CalculatePayment()
        {
            decimal monthlyRate = CalculateInterest();
            decimal paymentAmount = balance + monthlyRate;
            return paymentAmount;
        }

        public override string ToString()
        {
            return "As of " + CalculateDueDate() + ",\n" +
                clientName + " will owe $" + CalculatePayment()
                + ".";
        }
        #region getters/setters
        public int LoanID
        {
            get
            {
                return loanID;
            }

            set
            {
                loanID = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }

            set
            {
                dueDate = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                interestRate = value;
            }
        }

        public int MonthTerms
        {
            get
            {
                return monthTerms;
            }

            set
            {
                monthTerms = value;
            }
        }
        #endregion
    }
}
