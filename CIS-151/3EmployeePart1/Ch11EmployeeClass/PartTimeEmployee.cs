using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11EmployeeClass
{
    class PartTimeEmployee : Employee
    {
        private decimal hourlyRate;
        private int hoursWorked;
        #region getters/setters
        public decimal HourlyRate
        {
            get
            {
                return hourlyRate;
            }

            set
            {
                hourlyRate = value;
            }
        }

        public int HoursWorked
        {
            get
            {
                return hoursWorked;
            }

            set
            {
                hoursWorked = value;
            }
        }
        #endregion
        public PartTimeEmployee(string fname, string lname, string date,
            string ssn, string email, decimal tax,
            //PT Employee variables
            decimal rate, int hours) 
            : base(fname, lname, date, ssn, email, tax)
        {
            hourlyRate = rate;
            hoursWorked = hours;
        }
        public override string ToString()
        {
            return "Name: " + base.LastName + ", " + base.FirstName + 
                "\nSalary: " + DisplaySalary()
                ;
        }
        public override decimal DisplaySalary()
        {
            return hourlyRate * Convert.ToDecimal(hoursWorked);
        }
        public decimal TaxCalc()
        {
            return DisplaySalary() * (TaxRate * 0.01m);
        }
    }
}
