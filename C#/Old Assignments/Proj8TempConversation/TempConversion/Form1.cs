using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double inputNum = Convert.ToDouble(inputTxt.Text);
                outputLbl.Text = inputNum + " Fahrenheit is \n" +
                        ((inputNum - 32) * 5 / 9) + " Celsius".ToString(); //contains formula to convert fahrenheit to celsius

                //
            }
            catch
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
