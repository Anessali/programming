using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagelist102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index;
            index = Convert.ToInt32(textBox1.Text);

            pictureBox1.Image = imageList1.Images[index];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
