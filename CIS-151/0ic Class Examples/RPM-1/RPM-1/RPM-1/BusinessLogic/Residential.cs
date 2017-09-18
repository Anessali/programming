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
        private decimal resLawnCost;
        private double resAcreage;

        /// <summary>
        /// Default constructor - must supply property no
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
        /// <param name="resLawnCost"></param>
        /// <param name="resAcreage"></param>
        public Residential(int propNo,
                            string propName,
                            string propAddress1,
                            decimal propValue,
                            string resType,
                            decimal resLawnCost,
                            double resAcreage)
            : base(propNo,
                  propName,
                  propAddress1,
                  propValue)
        {
            this.resType = resType;
            this.resLawnCost = resLawnCost;
            this.resAcreage = resAcreage;
        }
        public string ResType
        {
            get { return resType; }
            set { resType = value; }
        }
        public decimal ResLawnCost
        {
            get { return resLawnCost;  }
            set { resLawnCost = value;  }
        }
        public double ResAcreage
        {
            get { return resAcreage; }
            set { resAcreage = value; }
        }
    }
}
