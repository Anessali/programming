using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_6WeightConv
{
    class WeightConverter
    {
        //private global variables
        private double kilograms;
        private double pounds;
        private double ounces;

        public WeightConverter(double kilograms, double pounds, double ounces)
        {
            this.kilograms = kilograms;
            this.pounds = pounds;
            this.ounces = ounces;
        }

        public static void ConvertToKilograms()
        {

        }

        //gets and sets
        public double Kilograms { get; set; }
        public double Pounds { get; set; }
        public double Ounces { get; set; }
    }
}
