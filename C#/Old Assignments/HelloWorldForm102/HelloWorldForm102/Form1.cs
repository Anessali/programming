using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForm102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lblTOD.Text = "Good morning";
            }
            else if (radioButton2.Checked)
            {
                lblTOD.Text = "Good afternoon";
            }
            else if (radioButton3.Checked)
            {
                lblTOD.Text = "Good evening";
            }
            else
            {
                lblTOD.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hannah is a pleb");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg;
            msg = "You loved our program " + numericUpDown1.Value + " times";

            MessageBox.Show(msg);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
