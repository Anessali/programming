using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Mortgage : Loan
    {
        decimal downPayment;
        decimal propertyValue;
        public Mortgage(decimal downPayment, decimal propertyValue, int loanID, 
            DateTime dueDate, decimal balance, decimal interestRate, int monthTerms)
            : base(loanID, dueDate, balance, interestRate, monthTerms)
        {
            this.downPayment = downPayment;
            this.propertyValue = propertyValue;
        }
        
        public decimal DownPayment { get; set; }
        public decimal PropertyValue { get; set; }
    }
}
