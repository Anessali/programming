using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTester
{
    /// <summary>
    /// Class:      Animal
    /// Developer:  TJ Liggett
    /// Date:       8/28/2017
    /// Purpose:    Base class for an animal
    /// </summary>
    public class Animal
    {
        #region private class fields
        private string species;
        private string name;
        private string color;
        private char size;
        private DateTime dateAcquired;
        #endregion
        public Animal() { }
        /// <summary>
        /// Animal constructs an animal
        /// this constructor requires all parameters
        /// </summary>
        /// <param name="species"></param>
        /// <param name="name"></param>
        /// <param name="color"></param>
        /// <param name="size"></param>
        /// <param name="dateAcquired"></param>
        public Animal(string species, string name, 
            string color, char size, DateTime dateAcquired)
        {
            this.species = species;
            this.name = name;
            this.color = color;
            this.size = size;
            this.dateAcquired = dateAcquired;
        }
        #region getters and setters
        public string Species
        {
            get
            {
                return species;
            }

            set
            {
                species = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public char Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public DateTime DateAcquired
        {
            get
            {
                return dateAcquired;
            }

            set
            {
                dateAcquired = value;
            }
        }
        #endregion
        /// <summary>
        /// Override the ToString to output
        /// meaningful animal info
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name +
                " is a " + 
                color +
                " " +
                species
                ;
        }
        /// <summary>
        /// Speak method returns the
        /// sound the animal makes
        /// </summary>
        /// <returns></returns>
        public virtual string Speak()
        {
            return "Animal sounds";
        }
    }
}
