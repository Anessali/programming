using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //random number is generated
            int num;
            Random randomize = new Random();
            //num passed into class to retrieve random image
            num = randomize.Next(0, 10);
            GetImg picOne = new GetImg(num);
            pBx1.ImageLocation = picOne.ToString();
            num = randomize.Next(0, 10);
            GetImg picTwo = new GetImg(num);
            pBx2.ImageLocation = picTwo.ToString();
            num = randomize.Next(0, 10);
            GetImg picThree = new GetImg(num);
            pBx3.ImageLocation = picThree.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double credits = 5.00;
            CreditCalc money = new CreditCalc(credits);
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCredit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
