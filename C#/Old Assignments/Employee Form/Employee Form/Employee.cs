using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Form
{
    public class Employee
    {
        #region global class variables
        private string lastName;
        private string firstName;
        private string jobTitle;
        private double salary;
        #endregion
        #region Getters and setters
        public string LastName {
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
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        public double Salary
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
        #endregion
        public Employee() { }
        public Employee( string last, string first,
            string job, double payRate)
        {
            lastName = last;
            firstName = first;
            jobTitle = job;
            salary = payRate;
        }
        public override string ToString()
        {
            return string.Format(
                "{0} {1, -20} {2} {3, 20}",
                LastName +", ",
                FirstName,
                JobTitle,
                Salary.ToString("C"));
        }
    }
}