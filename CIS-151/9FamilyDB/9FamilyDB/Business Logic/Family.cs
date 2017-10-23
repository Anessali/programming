using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9FamilyDB.Business_Logic
{
    class Family
    {
        private int famID;
        private string firstName;
        private string lastName;
        private string relationship;
        private string hometown;
        private int age;

        public Family()
        {

        }

        public Family(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
        public Family(int ID, string fName, string lName,
            string relation, string town, int age)
        {
            this.famID = ID;
            this.firstName = fName;
            this.lastName = lName;
            this.relationship = relation;
            this.hometown = town;
            this.age = age;
        }

        #region getters/setters
        public int FamID
        {
            get
            {
                return famID;
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

        public string Relationship
        {
            get
            {
                return relationship;
            }

            set
            {
                relationship = value;
            }
        }

        public string Hometown
        {
            get
            {
                return hometown;
            }

            set
            {
                hometown = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return firstName + " " + lastName + ", " + age + ", " + relationship + ", " + hometown;
        }
    }
}
