using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11EmployeeClass
{
    class FullTimeEmployee : Employee
    {
        private decimal salary;
        private int vacationDays;
        private int sickDays;
        private bool hasInsurance;
        private bool taxExempt;
        #region getters/setters
        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public int VacationDays
        {
            get
            {
                return vacationDays;
            }

            set
            {
                vacationDays = value;
            }
        }

        public int SickDays
        {
            get
            {
                return sickDays;
            }

            set
            {
                sickDays = value;
            }
        }

        public bool HasInsurance
        {
            get
            {
                return hasInsurance;
            }

            set
            {
                hasInsurance = value;
            }
        }

        public bool TaxExempt
        {
            get
            {
                return taxExempt;
            }

            set
            {
                taxExempt = value;
            }
        }
        #endregion

        public FullTimeEmployee(string fname, string lname, string date,
            string ssn, string email, decimal tax,
            //FT Employee variables
            decimal salary, int vacation, int sick, bool insurance, bool exempt) 
            : base(fname, lname, date, ssn, email, tax)
        {
            Salary = salary;
            vacationDays = vacation;
            sickDays = sick;
            hasInsurance = insurance;
            taxExempt = exempt;
        }
        public override string ToString()
        {
            return "Name: " + LastName + ", " + FirstName +
                "\nDate Hired: " + DateHired +
                "\nSocial: " + Ssn +
                "\nEmail: " + Email +
                "\nVacation Days: " + vacationDays +
                "\nSick Days: " + sickDays
                + "\nInsurance: " + hasInsurance;
        }
        public override decimal DisplaySalary()
        {
            return Salary;
        }
        //calculates taxes
        public virtual decimal TaxCalc()
        {
            return salary * (TaxRate * 0.01m);
        }
    }
}
