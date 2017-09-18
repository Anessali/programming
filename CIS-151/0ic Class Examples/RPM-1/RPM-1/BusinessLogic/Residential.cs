using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPM_1
{
    /// <summary>
    /// This class defines a residential property
    /// </summary>
    public class Residential : Property
    {
        private string resType;
        private decimal resLawnMaintCost;
        private double resAcres;

        /// <summary>
        /// Default contructor - must supply property number
        /// </summary>
        /// <param name="propNo"></param>
        public Residential(int propNo)
            : base(propNo)
        {

        }

        /// <summary>
        /// Constructor that expects all data params
        /// </summary>
        /// <param name="propNo"></param>
        /// <param name="propName"></param>
        /// <param name="propAddress1"></param>
        /// <param name="propValue"></param>
        /// <param name="resType"></param>
        /// <param name="resLawnMaintCost"></param>
        /// <param name="resAcres"></param>
        public Residential(int propNo, string propName, 
            string propAddress1, decimal propValue,
            string resType, decimal resLawnMaintCost,
            double resAcres)
            : base (propNo, propName, propAddress1, propValue)
        {
            this.resType = resType;
            this.resLawnMaintCost = resLawnMaintCost;
            this.resAcres = resAcres;
        }

        #region getters/setters
        public string ResType
        {
            get
            {
                return resType;
            }

            set
            {
                resType = value;
            }
        }

        public decimal ResLawnMaintCost
        {
            get
            {
                return resLawnMaintCost;
            }

            set
            {
                resLawnMaintCost = value;
            }
        }

        public double ResAcres
        {
            get
            {
                return resAcres;
            }

            set
            {
                resAcres = value;
            }
        }
        #endregion
    }
}
