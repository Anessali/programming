using System;
using System.Windows.Forms;

/*
    Name:   TJ Liggett
    Project:Pizza Delivery

     */

namespace Proj9PizzaDelivery
{
    public partial class Form1 : Form
    {
        //global variables
        double totalDrinkCost;
        double pizzaCost;
        string toppings = "Cheese";
        double sidesCost;
        public Form1()
        {
            InitializeComponent();
        }

        private void chkBxTea_CheckedChanged(object sender, EventArgs e)
        {
            //drink price variables
            double teaCost = 0,
                lemonadeCost = 0,
                sodaCost = 0,
                drinkSize = 0;
            //calculates price
            if (chkBxTea.Checked)
            {
                #region calculates added price for size
                if (cbTea.Text == "small"){
                    drinkSize = 0;
                }
                if (cbTea.Text == "medium")
                {
                    drinkSize = 0.30;
                }
                if (cbTea.Text == "large")
                {
                    drinkSize = 0.60;
                }
                #endregion 
                teaCost = (1.20 + drinkSize) * Convert.ToDouble(numUDTea.Text);
            }
            if (chkBxLemonade.Checked)
            {
                #region calculates added price for size
                if (cbLemonade.Text == "small")
                {
                    drinkSize = 0;
                }
                if (cbLemonade.Text == "medium")
                {
                    drinkSize = 0.30;
                }
                if (cbLemonade.Text == "large")
                {
                    drinkSize = 0.60;
                }
                #endregion 
                lemonadeCost = (1.50 + drinkSize) * Convert.ToDouble(numUDLemonade.Text);
            }
            if (chkBxSoda.Checked)
            {
                #region calculates added price for size
                if (cbSoda.Text == "small")
                {
                    drinkSize = 0;
                }
                if (cbSoda.Text == "medium")
                {
                    drinkSize = 0.30;
                }
                if (cbSoda.Text == "large")
                {
                    drinkSize = 0.60;
                }
                #endregion
                sodaCost = (1.00 + drinkSize) * Convert.ToDouble(numUDSoda.Text);
            }
            //final calculation
            totalDrinkCost = teaCost + lemonadeCost + sodaCost;
            lblDrinkPrices.Text = totalDrinkCost.ToString("C2");
            lblTotalPrice.Text = (pizzaCost + totalDrinkCost + sidesCost).ToString("C2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pizza variables
            double pizzaSize = 0,
                pizzaCrust = 0;
            #region base pizza costs based on size
            if (comboSize.Text == "small")
            {
                pizzaSize = 6.00;
            }
            if (comboSize.Text == "medium")
            {
                pizzaSize = 8.00;
            }
            if (comboSize.Text == "large")
            {
                pizzaSize = 11.00;
            }
            #endregion
            #region crust type price adjustments
            if (comboCrust.Text == "Regular") {
                pizzaCrust = 0;
            }
            if (comboCrust.Text == "Thin")
            {
                pizzaCrust = -0.50;
            }
            if (comboCrust.Text == "Deep Dish")
            {
                pizzaCrust = 1;
            }
            if (comboCrust.Text == "Pan")
            {
                pizzaCrust = 1;
            }
            if (comboCrust.Text == "Cheese-filled")
            {
                pizzaCrust = 1.50;
            }
            #endregion
            //final calculations for pizza
            pizzaCost = pizzaSize + pizzaCrust;
            lblPizza.Text = pizzaCost.ToString("C2");
            lblTotalPrice.Text = (pizzaCost + totalDrinkCost + sidesCost).ToString("C2");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region prices for sides
            if (comboSides.Text == "")
            {
                sidesCost = 0;
            }
            if (comboSides.Text == "Cheese Sticks")
            {
                sidesCost = 3.50;
            }
            if (comboSides.Text == "Cinnamon Sticks")
            {
                sidesCost = 4.00;
            }
            if (comboSides.Text == "Salad")
            {
                sidesCost = 5.00;
            }
            if (comboSides.Text == "Chicken Tenders")
            {
                sidesCost = 4.50;
            }
            #endregion

            lblSidesPrice.Text = sidesCost.ToString("C2");
            lblTotalPrice.Text = (pizzaCost + totalDrinkCost + sidesCost).ToString("C2");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtNumber.Text == "")
            {
                MessageBox.Show("Error. You are missing some necessary information");
            }
            else {
                MessageBox.Show(txtName.Text + ",\n" +
                    "Your " + toppings + " pizza meal will be delivered to " +
                    txtAddress.Text + "\n" + "Thank you for choosing Pizza Mutt!");
            }
        }

        private void cbxToppings_SelectedIndexChanged(object sender, EventArgs e)
        {
            toppings = cbxToppings.Text;
        }
    }
}