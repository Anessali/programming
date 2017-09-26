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
            try
            {
                /* ************************************************************ *
                 *   Declared Variables                                         *
                 *   values stored in variables to easily pass through methods  *
                 * **************************************************************/
                double weight = Convert.ToDouble(txtTempIn.Text);
                string weightBox = cboBxOne.Text,
                    convertBox = cboBxTwo.Text;
                if (weight < 0)
                {//throws exception if user enters a negative
                    throw new Exception();
                }
                //calls methods for calculations
                weight = ConvertToGrams(weight, weightBox);
                weight = Converter(convertBox, weight);
                //output of results
                txtTempOut.Text = weight.ToString();
            }
            catch
            {
                txtTempOut.Text = "Please enter a valid number";
            }
        }//closing method bracket

        public static double ConvertToGrams(double weight, string weightBox)
        {
            /* ********************************* *
             *  All numbers are set to grams     *
             *  for simple conversion.           *
             * ********************************* */
            if (weightBox == "kilograms")
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
        
        public static double Converter(string convertBox, double weight)
        {
            //weight variables initialized
            double kilograms = weight,
                pounds = weight,
                ounces = weight;//values converted based on variable name
            //a new instance of WeightConverter class is made using variables with weight value
            WeightConverter converter = new WeightConverter(kilograms, pounds, ounces);
            /*      outputs results based on converted values       */
            if(convertBox == "kilograms")
            {
                kilograms = converter.ConvertToKilograms();
                weight = kilograms;
            }
            else if(convertBox == "pounds")
            {
                pounds = converter.ConvertToPounds();
                weight = pounds;
            }
            else if(convertBox == "ounces")
            {
                ounces = converter.ConvertToOunces();
                weight = ounces;
            }
            return weight;
        }
    }
}