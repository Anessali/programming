using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Name:   TJ Liggett
Program:Hot and Cold Game
Date:   5/2/2017
                            */

namespace Hot_and_Cold_Game
{
    public partial class Form1 : Form
    {
        //creates random class public variable
        static Random guessNum = new Random();
        //int num = guessNum.Next(1, 1000);
        int num = guessNum.Next(1, 1000);
        //other public variables
        int numTracker;
        bool lever = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void Tester()
        {
            //lblTest.Text = num.ToString(); 
        }//used in testing
        private void Form1_Load(object sender, EventArgs e)
        {
            txtOpMessage.Text = "I have a number between 1 and \n" +
                "1000--can you guess my number?\n" + 
                " Please enter your first guess.";
            Tester();
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HighLow();
                HotCold();
                if (lever == true)
                    GameWon();
            }
            catch (Exception)
            {

            }
        }//mostly has method calls
        public void HighLow()
        {
            if (Convert.ToInt32(txtInput.Text) > num)
            {
                lblHighLow.Text = "Too high!";
            }
            if (Convert.ToInt32(txtInput.Text) < num)
            {
                lblHighLow.Text = "Too low!";
            }
            else if (Convert.ToInt32(txtInput.Text) == num)
            {
                lblHighLow.Text = "Correct!";
            }
        }//calculates lblHighLow
        public void HotCold()
        {
                if (Convert.ToInt32(txtInput.Text) != num)
                {
                    if (Math.Abs(num - Convert.ToInt32(txtInput.Text)) < Math.Abs(num - numTracker))
                    {
                        this.BackColor = ColorTranslator.FromHtml("#FA4F4F");//hex value is red
                    }
                    if (Math.Abs(num - Convert.ToInt32(txtInput.Text)) > Math.Abs(num - numTracker))
                    {
                        this.BackColor = ColorTranslator.FromHtml("#33adff");//hex value is blue
                    }
                    numTracker = Convert.ToInt32(txtInput.Text);
                }
                else
                {
                    lever = true;
                }
        }//calculates background color change - couldn't figure out proper way to do this. Might ask in class
        public void GameWon()
        {
            this.BackColor = ColorTranslator.FromHtml("#6fdc6f");//hex value is green
            btnNewGame.Enabled = true;
            txtInput.ReadOnly = true;
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            num = guessNum.Next(1, 1000);
            btnNewGame.Enabled = false;
            txtInput.ReadOnly = false;
            this.BackColor = Color.WhiteSmoke; //resets color
            lever = false;
            Tester();
        }
    }
}
