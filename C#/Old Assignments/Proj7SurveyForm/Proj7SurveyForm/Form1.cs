using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj7SurveyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFirst_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //variables
            string firstN = Convert.ToString(txtFirst.Text);
            string lastN = Convert.ToString(txtLast.Text);


            //displays final results
            if (lblOutput.Text != "")
            {
                lblOutput.Text = firstN + " " + lastN.ToString() + ",\n" + //displays name
                "Your survey has been received. Thank you for the feedback.";
            }
            else
            {
                lblOutput.Text = "Error. Survey not received. Please enter the necessary information.";
            }
        }
    }
}
