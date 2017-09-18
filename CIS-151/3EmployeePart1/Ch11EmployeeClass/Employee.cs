using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11EmployeeClass
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string dateHired;
        private string ssn;
        private string email;
        private decimal taxRate;
        #region getters/setters
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

        public string Ssn
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
        public Employee(string fname, string lname, string date,
            string ssn, string email, decimal tax)
        {
            FirstName = fname;
            LastName = lname;
            dateHired = date;
            this.ssn = ssn;
            this.email = email;
            taxRate = tax;
        }
        public override string ToString()
        {
            return "Name: " + LastName + ", " + FirstName +
                "\nDate Hired: " + dateHired +
                "\nSocial: " + ssn +
                "\nEmail: " + email + 
                "\nTax Rate: " + taxRate + "%"
                ;
        }
        public virtual decimal DisplaySalary()
        {
            return 10000M;
        }
    }
}
