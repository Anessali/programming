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
        int count = -1; //tracks string size - must start at -1
        double display; //for TryParse
        
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
            MessageBaka touka = new MessageBaka();
            touka.Show();
            //MessageBox.Show("Are you a baka hentai?", "B-baka...",
            //            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #region Visual Studio generated modules
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
            try
            {
                formula = formula.Remove(count, 1);
                count -= 1;
                Display();
            }
            catch (NullReferenceException)
            {
                //count = -1;
            }
            catch (ArgumentOutOfRangeException)
            {
                txtResults.Text = "No numbers to remove";
            }
        }//removes a character from display
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtResults.Text = txtDisplay.Text;
                if (txtDisplay.Text == "69")
                {
                    BakaHentai();
                }
                double.TryParse(txtDisplay.Text, out display);
            }
            catch
            {

            }
        }//controls displayed formulas
        #endregion
    }
}
