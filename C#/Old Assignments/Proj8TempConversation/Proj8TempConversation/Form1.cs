using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj8TempConversation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tempConvert;
            //tempConvert = (Convert.ToDouble(fahrenheit) - 32) * 5 / 9; //mathematical formula to convert fahrenheit
            //Convert.ToString(tempConvert);

            outputMsg.Text = fahrenheit.Text;
        }

        private void fahrenheit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}