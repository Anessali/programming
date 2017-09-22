using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11EmployeeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Employee myEmployee = new Employee(txtFirstName.Text, txtLastName.Text, 
                txtDateHired.Text, txtSsn.Text, txtEmail.Text, 
                Convert.ToDecimal(txtTax.Text));
            //MessageBox.Show(myEmployee.ToString());
            #region full time
            if (rdBtnFT.Checked)
            {
                FullTimeEmployee myFTEmployee = new FullTimeEmployee(txtFirstName.Text, txtLastName.Text,
                    txtDateHired.Text, txtSsn.Text, txtEmail.Text, Convert.ToDecimal(txtTax.Text), 
                    //class local
                    100000, 7, 5, true, true);
                

                //runs manager class
                if (chkBxManagement.Checked)
                {
                    Manager newManager = new Manager(txtFirstName.Text, txtLastName.Text,
                    txtDateHired.Text, txtSsn.Text, txtEmail.Text, Convert.ToDecimal(txtTax.Text),
                    //FullTimeEmployee variables
                    100000, 7, 5, true, true, 5000);
                    MessageBox.Show(newManager.ToString());
                    txtBonus.Text = Convert.ToString(newManager.Bonus());
                }
                else
                {
                    MessageBox.Show(myFTEmployee.ToString());
                    BonusMessage();
                }

                txtEmpSalary.Text = Convert.ToString(myFTEmployee.DisplaySalary());
                txtEmpTax.Text = Convert.ToString(myFTEmployee.TaxCalc());
                
            }
            #endregion
            #region part time
            else if (rdBtnPT.Checked)
            {
                PartTimeEmployee ptEmployee = new PartTimeEmployee(txtFirstName.Text, txtLastName.Text,
                    txtDateHired.Text, txtSsn.Text, txtEmail.Text, Convert.ToDecimal(txtTax.Text),
                    //data pulled from PartTime form
                    10m, 80
                    );
                
                MessageBox.Show(ptEmployee.ToString());
                txtEmpSalary.Text = Convert.ToString(ptEmployee.DisplaySalary());
                txtEmpTax.Text = Convert.ToString(ptEmployee.TaxCalc());
                BonusMessage();
            }
            #endregion
        }
        private void BonusMessage()
        {
            txtBonus.Text = "Not eligible";
        }
    }
}
