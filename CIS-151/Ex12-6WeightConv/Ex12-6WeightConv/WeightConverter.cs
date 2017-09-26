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

        public double ConvertToKilograms()
        {
            kilograms = kilograms * 0.00100;
            return kilograms;
        }

        public double ConvertToPounds()
        {
            pounds = pounds * 0.00220;
            return pounds;
        }

        public double ConvertToOunces()
        {
            ounces = ounces * 0.03527;
            return ounces;
        }
        #region getters and setters
        public double Kilograms
        {
            get
            {
                return kilograms;
            }

            set
            {
                kilograms = value;
            }
        }

        public double Pounds
        {
            get
            {
                return pounds;
            }

            set
            {
                pounds = value * 0.00220;
            }
        }

        public double Ounces
        {
            get
            {
                return ounces;
            }

            set
            {
                ounces = value * 0.03527;
            }
        }
        #endregion
    }
}
