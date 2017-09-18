using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal();
            txtBxSpecies.Text = myAnimal.Species;
            txtBxName.Text = myAnimal.Name;
            txtBxColor.Text = myAnimal.Color;
            txtBxResult.Text = myAnimal.ToString();
        }
    }
}
