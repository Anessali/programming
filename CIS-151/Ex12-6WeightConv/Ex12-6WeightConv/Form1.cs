using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12_6WeightConv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*      Declared Variables      */
            double weight = Convert.ToDouble(txtTempIn.Text),
                kilograms,
                pounds, 
                ounces;
            string weightBox = cboBxOne.Text; //value stored in variable to easily pass through methods
            
            //passes value into method to convert to gram
            weight = ConvertToGrams(weight, weightBox);

            //a new instance of WeightConverter class is made using variables with weight value
            kilograms = weight;
            pounds = weight;
            ounces = weight; //values converted based on variable name
            WeightConverter converter = new WeightConverter(kilograms, pounds, ounces);

            //outputs results based on converted values
            kilograms = converter.ConvertToKilograms();
            txtTempOut.Text = kilograms.ToString();
        }//closing method bracket

        public static double ConvertToGrams(double weight, string weightBox)
        {
            /* ********************************* *
             *  All numbers are set to grams     *
             *  for simple conversion.           *
             * ********************************* */
            if (weightBox == "grams")
            {

            }
            else if (weightBox == "kilograms")
            {
                //fomrula converts kilograms to grams
                weight = weight * 1000;
            }
            else if (weightBox == "pounds")
            {
                //fomrula converts pounds to grams
                weight = weight * 453.59232;
            }
            else if (weightBox == "ounces")
            {
                //fomrula converts ounces to grams
                weight = weight * 28.34952;
            }
            return weight;
        }//end of method
        
    }
}