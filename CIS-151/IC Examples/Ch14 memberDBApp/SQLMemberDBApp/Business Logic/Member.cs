using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMemberDBApp
{
    /// <summary>
    /// This defines the member table
    /// </summary>
    class Member
    {
        #region Class Fields (private variables)
        private int studentID;
        private string lastName;
        private string firstName;
        private string phoneNumber;

        public Member()
        {

        }
        public Member(string lName, string fName)
        {
            this.LastName = lName;
            this.FirstName = fName;
        }

        public Member(int sID, string lName, 
            string fName, string pNum)
        {
            this.studentID = sID;
            this.LastName = lName;
            this.FirstName = fName;
            this.PhoneNumber = pNum;
        }

        #region Getters/Setters (Public variables)
        public int StudentID
        {
            get
            {
                return studentID;
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

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }
        #endregion
        #endregion
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
