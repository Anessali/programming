using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02_Petals
{
    //TFS Test Comment
    public partial class Form1 : Form
    {
        Congratulations message = new Congratulations();
        #region global variables/arrays
        //used to cycle through arrays
        int index = 0; 
        //arrays
        int[] petals = new int[6] {0, 0, 2, 0, 4, 0};
        string[] location = new string[6] {"../../resources/dice1.jpg", "../../resources/dice2.jpg",
        "../../resources/dice3.jpg", "../../resources/dice4.jpg", "../../resources/dice5.jpg",
        "../../resources/dice6.jpg"};
        //variables to track petals
        int picOne, picTwo, picThree, picFour, picFive;
        //counts
        int rolls = 0;
        int correct = 0;
        int count = 0;
        int bestRun = 0;
        //
        bool cSwitch = true;
        #endregion
        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                if (cSwitch == true)
                {
                    txtBxResult.Text = "Roll dice";
                }
                else if (picOne + picTwo + picThree + picFour
                    + picFive == Convert.ToInt32(txtBxGuess.Text))
                {
                    correct += 1;
                    count += 1;
                    if (bestRun < count) //tracks best run value
                    {
                        bestRun = count;
                    }
                    lblCorrect.Text = correct.ToString();
                    txtBxResult.Text = "Correct!";
                    cSwitch = true;
                }
                else if (Convert.ToInt32(txtBxGuess.Text) % 2 != 0)
                {
                    txtBxResult.Text = "Please enter a positive number.";
                }
                else
                {
                    count = 0;
                    txtBxResult.Text = "Wrong!";
                    cSwitch = true;
                }
                lblBestRun.Text = bestRun.ToString();
                if (bestRun >= 6)
                {
                    message.Show();
                }
            }
            catch
            {
                txtBxResult.Text = "Error. Please enter valid number.";
            }
        }
        //import random
        Random roll = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            rolls += 1;
            lblRolls.Text = rolls.ToString();
            cSwitch = false;
            #region generates dice
            //First
            index = roll.Next(0, 6);
            pictureOne.ImageLocation = location[index];
            picOne = petals[index];
            //Second
            index = roll.Next(0, 6);
            pictureTwo.ImageLocation = location[index];
            picTwo = petals[index];
            //Third
            index = roll.Next(0, 6);
            pictureThree.ImageLocation = location[index];
            picThree = petals[index];
            //Fourth
            index = roll.Next(0, 6);
            pictureFour.ImageLocation = location[index];
            picFour = petals[index];
            //Fifth
            index = roll.Next(0, 6);
            pictureFive.ImageLocation = location[index];
            picFive = petals[index];
           
                #endregion
        }
    }
}