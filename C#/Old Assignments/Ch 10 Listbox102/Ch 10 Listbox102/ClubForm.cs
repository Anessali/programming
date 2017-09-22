using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_10_Listbox102
{
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstBxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.txtBoxStatus.Text =
            //    lstBxEvents.SelectedItem.ToString();
            string result = " ";

            foreach (string activity in lstBxEvents.SelectedItems)
            {
                result += activity + " ";
            }
            this.txtBoxStatus.Text = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newOne = txtBxActivity.Text;

            lstBxEvents.Items.Add(newOne); //add to the items 

            txtBxActivity.Text = "";  // either way works
            //txtBxActivity.Clear(); // either way works
        }
    }
}
