using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResidentialNameSpace;

namespace ResidentialTester
{
    
    public partial class Form1 : Form
    {
        private Residential myResProp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtBxPropNo.Text = myResProp.PropNo.ToString();
            txtBxPropName.Text = myResProp.PropName;
            txtBxPropAddress1.Text = myResProp.PropAddress1;
            txtBxPropValue.Text = myResProp.PropValue.ToString();

            txtType.Text = myResProp.ResType;
            txtLawnCost.Text = myResProp.ResLawnMaintCost.ToString();
            txtAcreage.Text = myResProp.ResAcres.ToString();

            txtBxRent.Text = myResProp.RentCalc(myResProp.PropValue).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myResProp = new Residential(111, "Beluga", "217 Ocean Lane", 50000, "Home", 50, 0.5);
        }
    }
}
