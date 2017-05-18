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
        char num;
        string formula;
        int count = -1; //tracks string size
        public Form1()
        {
            InitializeComponent();
        }
        private void Display()
        {
            txtDisplay.Text = formula;
        }//sets txtDisplay to formula
        private void BakaHentai()
        {
            MessageBox.Show("Are you a baka hentai?", "B-baka...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        /// <summary>
        /// Below are Windows Forms 
        /// generated modules
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            //txtDisplay.SelectionStart()
            string displayStorage = txtDisplay.Text;
            lblFocus.Text = "";
            txtDisplay.BackColor = Color.FromArgb(217, 179, 255);
            txtResults.BackColor = Color.FromArgb(217, 179, 255);

        }
        private void btn_click(object sender, EventArgs e)
        {
            lblFocus.Focus(); //pulls focus off of buttons when pressed
            num = Convert.ToChar((sender as Button).Text);
            count += 1;
            formula += num;
            Display();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            formula = "";
            txtDisplay.Clear();
            count = -1;
            Display();
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            formula = formula.Remove(count, 1);
            count -= 1;
            Display();
        }//removes a character from display
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text == "69")
                {
                    BakaHentai();
                }
                else {
                    double display;
                    double.TryParse(txtDisplay.Text, out display);
                    txtResults.Text = display.ToString();
                }
            }
            catch
            {

            }
        }//controls displayed formulas
    }
}
