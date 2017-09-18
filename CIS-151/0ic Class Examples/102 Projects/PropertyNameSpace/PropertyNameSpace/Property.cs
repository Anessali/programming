using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyNameSpace
{
    /// <summary>
    /// Property class
    /// defines a property object
    /// </summary>
    public abstract class Property //abstract makes it so you cannot instantiate the class
    {
        // private class fields
        private int propNo;
        private string propName;
        private string propAddress1;
        private decimal propValue;

        /// <summary>
        /// Constructor using all properties
        /// </summary>
        /// <param name="propNo"></param>
        /// <param name="propName"></param>
        /// <param name="propAddress1"></param>
        /// <param name="propValue"></param>
        public Property(int propNo, string propName, 
            string propAddress1, decimal propValue)
        {
            this.propNo = propNo;
            this.propName = propName;
            this.propAddress1 = propAddress1;
            this.propValue = propValue;
        }
        /// <summary>
        /// Constructor with required Property Number parameter
        /// </summary>
        /// <param name="propNo"></param>
        public Property(int propNo)
        {
            this.propNo = propNo;
        }
        public int PropNo
        {
            get
            {
                return propNo;
            }
            // Prop No is read only
            //set
            //{
            //    propNo = value;
            //}
        }

        public string PropName
        {
            get
            {
                return propName;
            }

            set
            {
                propName = value;
            }
        }

        public string PropAddress1
        {
            get
            {
                return propAddress1;
            }

            set
            {
                propAddress1 = value;
            }
        }

        public decimal PropValue
        {
            get
            {
                return propValue;
            }

            set
            {
                propValue = value;
            }
        }
        /// <summary>
        /// ToString method to return info about our object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "No: " + propNo +
                    " Name: " + propName +
                    " Add1: " + propAddress1 +
                    " Val: " + propValue +
                    "\r\n";
        }
        /// <summary>
        /// This method will calculate the property tax
        /// </summary>
        /// <returns></returns>
        public virtual decimal CalcPropTax()
        {
            return propValue * .2M;
        }
    }
}
