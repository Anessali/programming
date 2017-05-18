using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shiro_s_Calculator
{
    public partial class Form1 : Form
    {
        //public variables
        string formula = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblFocus.Text = "";
        }
        private void btn_click(object sender, EventArgs e)
        {
            lblFocus.Focus(); //pulls focus off of buttons when pressed

            formula += (sender as Button).Text;
            txtDisplay.Text = formula;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}
