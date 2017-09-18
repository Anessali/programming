using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPM_1
{
    public partial class frmProperty : Form
    {
        public frmProperty()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                // Commercial
                LoadCommercial();
            }
            else
            {
                // Residential
                LoadResidential();
            }
        }
        private void LoadResidential()
        {             // TODO: add code for error checking
            int propNo = Convert.ToInt32(txtBxPropNo.Text);

            Residential thisProp = new Residential(propNo);

            // update values
            thisProp.PropName = txtBxPropName.Text;
            thisProp.PropAddress1 = txtBxPropAddress1.Text;
            thisProp.PropValue = Convert.ToInt32(txtBxPropValue.Text);

            thisProp.ResType = txtBxType.Text;
            thisProp.ResLawnCost = Convert.ToDecimal(txtBxLawnCost.Text);
            thisProp.ResAcreage = Convert.ToDouble(txtBxAcreage.Text);
            lblStatus.Text = "Property Added";

            txtBxAll.Text += thisProp;
        }
        private void LoadCommercial()
        {             // TODO: add code for error checking
            int propNo = Convert.ToInt32(txtBxPropNo.Text);

            Commercial thisProp = new Commercial(propNo);

            // update values
            thisProp.PropName = txtBxPropName.Text;
            thisProp.PropAddress1 = txtBxPropAddress1.Text;
            thisProp.PropValue = Convert.ToInt32(txtBxPropValue.Text);

            thisProp.ComLotCost = Convert.ToDecimal(txtBxLotCost.Text);
            thisProp.ComSecurityCost = Convert.ToDecimal(txtBxSecurityCost.Text);
            lblStatus.Text = "Property Added";

            txtBxAll.Text += thisProp;
        }
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                // Commercial
                grpCommercial.Enabled = true;
                grpCommercial.Visible = true;

                grpResidential.Enabled = false;
                grpResidential.Visible = false;
            }
            else
            {
                // Residential
                grpResidential.Enabled = true;
                grpResidential.Visible = true;

                grpCommercial.Enabled = false;
                grpCommercial.Visible = false;
            }
        }
    }
}
