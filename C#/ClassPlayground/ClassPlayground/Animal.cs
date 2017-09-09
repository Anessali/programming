using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    class Animal
    {
        private string species;
        private string name;
        private string color;

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

        public Animal()
        {

        }

        public Animal(string species, string name, 
            string color)
        {
            this.species = species;
            this.name = name;
            this.color = color;
        }

        public virtual string Bark()
        {
            if (species == "dog")
            {
                string bork = "Bork bork bork!";
                return bork;
            }
            else if(species == "cat") {
                string meow = "ummm... meow?";
                return meow;
            }
            else
            {
                string growl = "GRRRRRRRRR";
                return growl;
            }
        }

        public override string ToString()
        {
            return name + " is a " +
                color + " " + species 
                + "."
                ;
        }
    }
}
