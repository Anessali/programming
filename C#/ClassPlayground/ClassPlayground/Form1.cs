using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPlayground
{
    public partial class Form1 : Form
    {
        string bork;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Animal dog = new Animal();
            dog.Species = txtSpecies.Text.ToLower();
            dog.Name = txtName.Text;
            dog.Color = txtColor.Text;
            bork = dog.Bark();
            txtBark.Text = dog.ToString();
            txtGrowl.Text = bork;
        }
    }
}
