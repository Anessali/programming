using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class PersonalLoan : Loan
    {
        public PersonalLoan(int loanID, DateTime dueDate, decimal balance,
            decimal interestRate, int monthTerms)
            : base(loanID, dueDate, balance, interestRate, monthTerms)
        {

        }
    }
}
