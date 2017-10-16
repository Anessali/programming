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
        //global variables
        public decimal credits = 1.00m;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            /* ******************************** *
             * This is the bulk of the code.    *
             * User cannot proceed if they run  *
             * out of credits.                  *
             * ******************************** */
            //random number is generated
            int num;
            //variables used to compare images
            int one = 0, 
                two = 0, 
                three = 0;
            Random randomize = new Random();
            
            if (credits > 0.00m)
            {
                //num passed into class to retrieve random image
                num = randomize.Next(0, 10);
                one = num;
                GetImg picOne = new GetImg(num);
                pBx1.ImageLocation = picOne.ToString();
                num = randomize.Next(0, 10);
                two = num;
                GetImg picTwo = new GetImg(num);
                pBx2.ImageLocation = picTwo.ToString();
                num = randomize.Next(0, 10);
                three = num;
                GetImg picThree = new GetImg(num);
                pBx3.ImageLocation = picThree.ToString();

                if (one == two && two == three)
                {
                    credits += 1;
                    txtCredit.Text = "¥" + credits.ToString();
                    txtResult.Text = "Win!";
                }
                if (one == two || one == three || two == three)
                {
                    credits += 0.10m;
                    txtCredit.Text = "¥" + credits.ToString();
                    txtResult.Text = "Win!";
                }
                else
                {
                    credits -= 0.10m;
                    txtCredit.Text = "¥" + credits.ToString();
                    txtResult.Text = "Loss!";
                }
            }
            else
            {
                txtCredit.Text = "Out of credits!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCredit.Text = "¥" + credits.ToString();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void purchaseCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
