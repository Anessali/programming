using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11EmployeeClass
{
    class Manager : FullTimeEmployee
    {
        decimal bonusEarned;
        public Manager(string fname, string lname, string date,
            string ssn, string email, decimal tax,
            //variables from FT Employee
            decimal salary, int vacation, int sick, bool insurance, bool exempt,
            decimal bonus) 
            : base(fname, lname, date, ssn, email, tax, salary, vacation, sick, 
                  insurance, exempt)
        {
            bonusEarned = bonus;
        }
        public override decimal TaxCalc()
        {
            return (Salary + bonusEarned) * (TaxRate * 0.01m);
        }

        public decimal Bonus()
        {
            return bonusEarned;
        }

        public override string ToString()
        {
            return "Name: " + LastName + ", " + FirstName +
                "\nDate Hired: " + DateHired +
                "\nSocial: " + Ssn +
                "\nEmail: " + Email +
                "\nVacation Days: " + VacationDays +
                "\nSick Days: " + SickDays + 
                "\nInsurance: " + HasInsurance + 
                "\nBonus: " + bonusEarned
            ;
        }
    }
}
