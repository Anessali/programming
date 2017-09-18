using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPM_1
{
    /// <summary>
    /// Defines a commercial property
    /// </summary>
    class Commercial : Property
    {
        private decimal comLotCost;
        private decimal comSecurityCost;

        /// <summary>
        /// default constructor - property number required
        /// </summary>
        /// <param name="propNo"></param>
        public Commercial(int propNo)
            : base (propNo)
        {

        }

        /// <summary>
        /// constructor with all parameters
        /// </summary>
        /// <param name="propNo"></param>
        /// <param name="propName"></param>
        /// <param name="propAddress1"></param>
        /// <param name="propValue"></param>
        /// <param name="comLotCost"></param>
        /// <param name="comSecurityCost"></param>
        public Commercial(int propNo, string propName, string propAddress1,
            decimal propValue, decimal comLotCost, decimal comSecurityCost)
            : base(propNo, propName, propAddress1, propValue)
        {
            this.comLotCost = comLotCost;
            this.comSecurityCost = comSecurityCost;
        }

        public decimal ComLotCost
        {
            get
            {
                return comLotCost;
            }

            set
            {
                comLotCost = value;
            }
        }

        public decimal ComSecurityCost
        {
            get
            {
                return comSecurityCost;
            }

            set
            {
                comSecurityCost = value;
            }
        }
        public override decimal CalcPropTax()
        {
            return PropValue * .25M;
        }
    }
}
