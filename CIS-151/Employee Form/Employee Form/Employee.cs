using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Form
{
    public class Employee
    {

        private string lastName;
        private string firstName;
        private string dateHired;
        private int ssn;
        private string email;
        private decimal taxRate;

        #region getters/setters
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string DateHired
        {
            get
            {
                return dateHired;
            }

            set
            {
                dateHired = value;
            }
        }

        public int Ssn
        {
            get
            {
                return ssn;
            }

            set
            {
                ssn = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public decimal TaxRate
        {
            get
            {
                return taxRate;
            }

            set
            {
                taxRate = value;
            }
        }
        #endregion
        public Employee() { }
        public Employee( string last, string first, string date, 
            int ssn, string email, decimal tax)
        {
            lastName = last;
            firstName = first;
            dateHired = date;
            this.ssn = ssn;
            this.email = email;
            taxRate = tax;
        }
        public override string ToString()
        {
            return string.Format(
                "{0} {1, -20} {2} {3, 20} {5}",
                LastName + ", ", FirstName,
                dateHired,
                ssn,
                email,
                taxRate + "%"
                //Salary.ToString("C")
                );
        }
    }
}