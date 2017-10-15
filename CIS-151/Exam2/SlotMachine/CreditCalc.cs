using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class CreditCalc
    {
        private double credits;

        public CreditCalc(double credits)
        {
            this.credits = credits;
        }

        public double Credits
        {
            get { return credits; }
            set { credits = value;  }
        }
    }
}
