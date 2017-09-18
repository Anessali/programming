using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Form
{
    public partial class NewEmployeeForm : Form
    {
        Employee globalVar;
        public NewEmployeeForm(ref Employee thisVar)
        {
            InitializeComponent();
            globalVar = thisVar;
        }

        private void btnConfirmNew_Click(object sender, EventArgs e)
        {
            globalVar.FirstName = txtFirst.Text;
            globalVar.LastName = txtLast.Text;
            globalVar.DateHired = bxHireDate.Text;
            globalVar.Ssn = Convert.ToInt32(txtSSN.Text);
            globalVar.Email = txtEmail.Text;
            this.Close();
        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            txtFirst.Text = globalVar.FirstName;
            txtLast.Text = globalVar.LastName;
            txtSSN.Text = Convert.ToString(globalVar.Ssn);
            
        }
    }
}