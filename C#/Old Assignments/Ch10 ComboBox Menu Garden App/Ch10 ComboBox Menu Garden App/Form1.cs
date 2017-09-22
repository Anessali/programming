using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch10_ComboBox_Menu_Garden_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click on a flower to add it to textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmboFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //makes selected text appear in textbox
            txtBxFlowerResult.Text = cmboFlowers.Text;
        }
        private void cmboFlowers_TextChanged(object sender, EventArgs e)
        {
            //txtBxFlowerResult.Text = cmboFlowers.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBxTreesResult.Text = "";
            foreach (int i in lstBxTrees.SelectedIndices)
            {
                txtBxTreesResult.Text += lstBxTrees.Items[i] + "\r\n";
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gardening Guide " +
                "Application\n\n\nVersion 1.0", "About Gardening");
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = lblMessage.Font;

            if (fontDialog1.ShowDialog() !=
                DialogResult.Cancel)
            {
                lblMessage.Font = fontDialog1.Font;
            }
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblMessage.ForeColor;
            if (colorDialog1.ShowDialog() !=
                DialogResult.Cancel)
            {
                lblMessage.ForeColor = colorDialog1.Color;
            }
        }

        private void txtBxTreesResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
